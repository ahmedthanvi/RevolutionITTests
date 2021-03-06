# Revolution IT Tech challenge

## About
This is a simple .NET implementation to the technical challenge provided by Revolution IT.
Please note there is not solution file, rather there are two projects in the repository.

1-	WeatherAPIWinForm
When you run this in Visual studio, it will display you a form which will ask for the City you want to forecast.
As per requirement, I have added two filters, so you can query the days based on your required temperature.
You can also view report for only the sunny days forecast.

(I would have used Angular or React, but since I time boxed finishing the test within an hour so I chose Windows Forms GUI as it is quickest to build)

2-	WeatherAPI.Integration.Tests
I have added integration test for the functional requirement.
I have also added few edge cases which verify that unauthorized users without API Key can’t receive forecast, and the response content type is what is set by the consumer of API.
I have used BDD approach, so using specflow I have created a feature file and steps file.

Please note I have added integration tests verify the WeatherAPI integration. I have not written the unit tests for the WinForm. This is what I wanted to clarify.



## Installation

Please clone/download the repostiory of technical test here at GitHub:
https://github.com/ahmedthanvi/RevolutionITTests.git

You just need to open this project in visual studio and build. The dependencies will be downloaded and built by itself.

1-	WeatherAPIWinForm

Just Run the win form (Hit Start button in Visual studio)

The form will open and ask for the city.
It will also ask how to filter the report for temperature greater than X degrees. 
You can also choose whether you want to see only the sunny days in the forecast by clicking the checkbox
When you hit Start button, it will show you the Forecast report based on the input.


2-	WeatherAPI.Integration.Tests

Open the project in Visual Studio.
Open Test Explorer winow.
Click 'Run ALL', and it will run all the specflow scenarios in the feature file.

Feature: WeatherAPI
	In order to have a happy holiday
	As a holiday maker
	I want to be able to receive weather forecast

@WeatherAPI-FunctionalTests
Scenario Outline: A happy holiday maker
	Given I like to holiday in <city>
	And I only like to holiday on <day>
	When I look up the weather forecast
	Then I receive the weather forecast
	And the temperature is warmer than <minimum temperature> degrees
	
	Examples:
    | city      | day      | minimum temperature |
    | Sydney,AU | Thursday | 10                  |

Scenario: WeatherAPI rejects the request that does not provide API Key
	Given I like to holiday
	When I look up the weather forecast without providing API Key
	Then I receive Unauthorised error

Scenario: WeatherAPI returns a json type response when Response mode is set to json
	Given I like to holiday
	When I set response type as json
	And I look up the weather forecast	
	Then the response returned is in json format

Scenario: WeatherAPI returns a XML type response when Response mode is set to xml
	Given I like to holiday 
	When I set response type as xml
	And I look up the weather forecast 
	Then the response returned is in XML format

Scenario: WeatherAPI's default Response mode is JSON
	Given I like to holiday 
	When I do not set response type
	And I look up the weather forecast
	Then the response returned is in JSON format


## Dependencies

* Newtonsoft.Json 7.0.1+ ([nuget link](https://www.nuget.org/packages/Newtonsoft.Json/7.0.1))

## License

This project is available under the MIT license. See the LICENSE file for more info.
