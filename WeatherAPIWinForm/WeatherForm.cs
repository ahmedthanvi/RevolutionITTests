using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Xml;
using System.IO;
using System.Globalization;

namespace WeatherAPIWinForm
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }

        // Enter your API key here.
        // Get an API key by making a free account at:
        //      http://home.openweathermap.org/users/sign_in
        private const string API_KEY = "6661b0cc8eceeec99efb93fb01eb49b6";

        // Query URLs. Replace @LOC@ with the location.
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "@QUERY@=@LOC@&mode=xml&units=metric&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=metric&APPID=" + API_KEY;

        private const string sunnyDayID = "800";

        // Query codes.
        private string[] QueryCodes = { "q", "id", };

        // Fill in query types. These should match the QueryCodes.
        private void Form1_Load(object sender, EventArgs e)
        {
            cboQuery.Items.Add("City");
            cboQuery.Items.Add("ID");

            cboQuery.SelectedIndex = 0;
        }

        // Get a forecast.
        private void btnForecast_Click(object sender, EventArgs e)
        {
            // Compose the query URL.
            string url = ForecastUrl.Replace("@LOC@", txtLocation.Text);
            url = url.Replace("@QUERY@", QueryCodes[cboQuery.SelectedIndex]);

            // Create a web client.
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL.
                try
                {
                    DisplayForecast(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }
        }

        // Display the forecast.
        private void DisplayForecast(string xml)
        {
            // Load the response into an XML document.
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);

            lvwForecast.Items.Clear();
            char degrees = (char)176;

            int filterTemp = 0;
            int userVal;

            if (int.TryParse(txtBoxfiltertemp.Text, out userVal))
            {
                filterTemp = userVal;
            }

            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {
                // Get the time in UTC.
                DateTime time =
                    DateTime.Parse(time_node.Attributes["from"].Value,
                        null, DateTimeStyles.AssumeUniversal);

                // Get the temperature.
                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                string temp = temp_node.Attributes["value"].Value;

                if (temp.Length > 1 && Convert.ToDecimal(temp) > filterTemp)
                {
                    if (!chkBoxSunny.Checked || IsSunny(time_node))
                    {
                        ListViewItem item = lvwForecast.Items.Add(time.DayOfWeek.ToString());
                        item.SubItems.Add(time.ToShortTimeString());
                        item.SubItems.Add(temp + degrees);
                        item.SubItems.Add(IsSunny(time_node).ToString());
                    }
                }
            }
        }

        private bool IsSunny(XmlNode sunny_node)
        {
            // Get if it is sunny
            XmlNode sunnyNode = sunny_node.SelectSingleNode("symbol");
            bool IsSunny = false;

            if (sunnyNode != null && sunnyNode.Attributes["number"].Value == sunnyDayID)
            {
                IsSunny = true;
            }

            return IsSunny;
        }

        // Display an error message.
        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error\n" + ex.Message);
            }
        }
    }
}
