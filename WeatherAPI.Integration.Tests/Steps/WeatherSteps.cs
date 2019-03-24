using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Net;
using TechTalk.SpecFlow;
using FluentAssertions;
//using WeatherAPIIntegration.Tests.Utilities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace WeatherAPIIntegration.Tests.Features
{
    [Binding]
    public class WeatherAPISteps
    {
        private UriBuilder OpenWeatherMapUri { get; } = new UriBuilder("http://api.openweathermap.org/data/2.5/forecast");
        private IRestResponse Response { get; set; }
        private string JsonContentType = "application/json; charset=utf-8";
        private string XMLContentType = "application/xml; charset=utf-8";
        private string City { get; set; }
        private string APIKey { get; set; }
        private DayOfWeek DayOfHoliday { get; set; }
        private JObject ResponseBody { get; set; }
        private string defaultCity = "Sydney";
        private IList<double> MinimumTemp { get; } = new List<double>();

        public WeatherAPISteps()
        {
            APIKey = ConfigurationManager.AppSettings["apiKey"];
        }

        [Given(@"I like to holiday in (.*)")]
        public void GivenILikeToHolidayIn(string city)
        {
            City = city;
            OpenWeatherMapUri.Query = "q=" + City + "&units=metric&appid=" + APIKey;
        }

        [Given(@"I only like to holiday on (.*)")]
        public void GivenIOnlyLikeToHolidayOn(string day)
        {
            DayOfWeek holidaydayOfWeek;
            if (Enum.TryParse(day, true, out holidaydayOfWeek))
                DayOfHoliday = holidaydayOfWeek;
        }

        [Given(@"I like to holiday")]
        public void GivenILikeToHoliday()
        {
            City = defaultCity;
        }

        [When(@"I look up the weather forecast")]
        public void WhenILookUpTheWeatherForecast()
        {
            var client = new RestClient(OpenWeatherMapUri.Uri);
            var request = new RestRequest(Method.GET);
            Response = client.Execute(request);                    
        }
        
        [When(@"I look up the weather forecast without providing API Key")]
        public void WhenILookUpTheWeatherForecastWithoutProvidingAPIKey()
        {
            OpenWeatherMapUri.Query = "q=" + City + "&units=metric&appid=" + string.Empty;
            var client = new RestClient(OpenWeatherMapUri.Uri);
            var request = new RestRequest(Method.GET);
            Response = client.Execute(request);
        }      

        [When(@"I set response type as json")]
        public void WhenISetResponseTypeAsJson()
        {
            OpenWeatherMapUri.Query = "q=" + City + "&units=metric&appid=" + APIKey + "&mode=json";
            var client = new RestClient(OpenWeatherMapUri.Uri);
            var request = new RestRequest(Method.GET);
            Response = client.Execute(request);
        }

        [When(@"I set response type as xml")]
        public void WhenISetResponseTypeAsXml()
        {
            OpenWeatherMapUri.Query = "q=" + City + "&units=metric&appid=" + APIKey + "&mode=xml";
            var client = new RestClient(OpenWeatherMapUri.Uri);
            var request = new RestRequest(Method.GET);
            Response = client.Execute(request);
        }

        [When(@"I do not set response type")]
        public void WhenIDoNotSetResponseType()
        {
            // No need to set anything here
        }        

        [Then(@"I receive the weather forecast")]
        public void ThenIReceiveTheWeatherForecast()
        {
            Response.StatusCode.Should().Be(HttpStatusCode.OK, "We need a valid response to know the forecast.");

            //assert for json validation.
            IsValidJson(Response.Content).Should().BeTrue();

            ResponseBody = JObject.Parse(Response.Content);
            string[] cityAndCountry = City.Split(',');
            ResponseBody["city"]["name"].Value<string>()
                .Should()
                .Be(cityAndCountry[0], "returned forecast should of same city");
            if (cityAndCountry.Length > 1)
                ResponseBody["city"]["country"].Value<string>()
                    .Should()
                    .Be(cityAndCountry[1], "returned forecast should of same country");
        }

        [Then(@"I receive Unauthorised error")]
        public void ThenIReceiveUnauthorisedError()
        {
            Response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Then(@"the response returned is in json format")]
        public void ThenTheResponseReturnedIsInJsonFormat()
        {
            Response.StatusCode.Should().Be(HttpStatusCode.OK, "We need a valid response to know the forecast.");
            Response.ContentType.Should().Be(JsonContentType);            
        }

        [Then(@"the response returned is in XML format")]
        public void ThenTheResponseReturnedIsInXMLFormat()
        {
            Response.StatusCode.Should().Be(HttpStatusCode.OK, "We need a valid response to know the forecast.");
            Response.ContentType.Should().Be(XMLContentType);
        }

        [Then(@"the response returned is in JSON format")]
        public void ThenTheResponseReturnedIsInJSONFormat()
        {
            Response.ContentType.Should().Be(JsonContentType);
        }

        [Then(@"I receive Status Code OK")]
        public void ThenIReceiveStatusCodeOK()
        {
            Assert.AreEqual(Response.StatusCode, HttpStatusCode.OK);
        }

        private static bool IsValidJson(string jsonString)
        {
            jsonString = jsonString.Trim();
            if ((jsonString.StartsWith("{") && jsonString.EndsWith("}")) || //For object
                (jsonString.StartsWith("[") && jsonString.EndsWith("]"))) //For array
            {
                try
                {
                    JToken.Parse(jsonString);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return false;
        }

        [Then(@"the temperature is warmer than (.*) degrees")]
        public void ThenTheTemperatureIsWarmerThanDegrees(string minimumTemperature)
        {
            double expectedMinumumTemp = Convert.ToDouble(minimumTemperature);
            var responseBody = JObject.Parse(Response.Content);
            var listOfForecasts = JArray.Parse(responseBody["list"].ToString());
            foreach (var forecast in listOfForecasts)
            {
                if (IsForecastFortheDayOfTheHoliday(forecast))
                {
                    GetMinimumTemperature(forecast);
                }
            }
            MinimumTemp.Count.Should().BeGreaterThan(0, "We need the forecast for the day of the holiday");
            MinimumTemp.Min().Should().BeGreaterThan(expectedMinumumTemp, "It should be warmer");
        }

        private bool IsForecastFortheDayOfTheHoliday(JToken forecast)
        {
            var dateOfForcast = forecast["dt_txt"].Value<DateTime>();
            return dateOfForcast.DayOfWeek.Equals(DayOfHoliday);
        }

        private void GetMinimumTemperature(JToken forecast)
        {
            var minimumTempForQuarter = forecast["main"]["temp_min"].Value<double>();
            MinimumTemp.Add(minimumTempForQuarter);
        }
    }
}
