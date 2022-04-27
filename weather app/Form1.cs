using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace weather_app
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();


            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {

                Day newday = new Day();


                reader.ReadToFollowing("time");
                newday.date = reader.GetAttribute("day");

                reader.ReadToFollowing("temperature");
                newday.tempLow = reader.GetAttribute("min");
                reader.ReadToFollowing("temperature");
                newday.tempHigh = reader.GetAttribute("max");


                if (newday.date != null)
                {
                    days.Add(newday);
                }

            }
        }

        private void ExtractCurrent()
        {

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");



        }
    }
}
    