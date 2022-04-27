using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather_app
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
          Citylabel.Text = Form1.days[0].location;
           Currenttemp.Text = Form1.days[0].currentTemp;
           min.Text = Form1.days[0].tempLow;
            max.Text = Form1.days[0].tempHigh;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
         
        }

        private void forecastLabel_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
