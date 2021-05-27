using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeatherNet;
using WeatherNet.Clients;

namespace Widget
{
    public partial class Widget : Form
    {
        public Widget()
        {
            InitializeComponent();
        }

        void Widget_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            MatchCollection currency = GetAllCurrency(wc.DownloadString($"http://www.cbr.ru/scripts/XML_daily.asp"));
            for (int i = 0; i < currency.Count; i++)
                listBoxExchangeRate.Items.Add(GetCurrencyRateValue(wc.DownloadString($"http://www.cbr.ru/scripts/XML_daily.asp"), currency[i].Value));

            List<Zodiak> zodiak = new List<Zodiak> {
                    new Zodiak{ Name = "Для всех знаков",  Link = "" },
                    new Zodiak{ Name = "Овен",     Link = "?znak=aries" },
                    new Zodiak{ Name = "Телец",    Link = "?znak=taurus"},
                    new Zodiak{ Name = "Близнецы", Link = "?znak=gemini"},
                    new Zodiak{ Name = "Рак",      Link = "?znak=cancer"},
                    new Zodiak{ Name = "Лев",      Link = "?znak=leo"},
                    new Zodiak{ Name = "Дева",     Link = "?znak=virgo"},
                    new Zodiak{ Name = "Весы",     Link = "?znak=libra"},
                    new Zodiak{ Name = "Скорпион", Link = "?znak=scorpio"},
                    new Zodiak{ Name = "Стрелец",  Link = "?znak=sagittarius"},
                    new Zodiak{ Name = "Козерог",  Link = "?znak=capricorn"},
                    new Zodiak{ Name = "Водолей",  Link = "?znak=aquarius"},
                    new Zodiak{ Name = "Рыбы",     Link = "?znak=pisces"},};

            comboBoxZodiak.DataSource = zodiak;
            comboBoxZodiak.DisplayMember = "Name";
            comboBoxZodiak.ValueMember = "Link";
            comboBoxZodiak.SelectedItem = 0;

            GetWeather();
        }

        string GetCurrencyRateValue(string url, string item)
        {
            Match value = Regex.Match(url, $"{item}<NumCode>(.*?)</NumCode><CharCode>(.*?)</CharCode><Nominal>(.*?)</Nominal><Name>(.*?)</Name><Value>(.*?)</Value>");
            return  String.Format("{0}: {1:f2} руб.", value.Groups[2].Value, Math.Round(Convert.ToDouble(value.Groups[5].Value), 2));
        }

        void GetWeather()
        {
            ClientSettings.ApiUrl = "http://api.openweathermap.org/data/2.5";
            ClientSettings.ApiKey = "c860088c13823a82fdfed25a4513e4bb";
           
            var result = CurrentWeather.GetByCityName("Yartsevo", "RU", "ru", "metric");
            groupBoxWeather.Text = "Погода в " + result.Item.City + ", (" + result.Item.Date.AddHours(3) + ")";
            labelWeather.Text = String.Format("Температура: {0} °C , {1}" + Environment.NewLine +
                                              "Относительная влажность: {2} %" + Environment.NewLine +
                                              "Скорость ветра: {3} м/с",
            result.Item.Temp, result.Item.Description , result.Item.Humidity, result.Item.WindSpeed);
            pictureBoxWeather.ImageLocation =  "http://openweathermap.org/img/w/" + result.Item.Icon + ".png";
        }

        MatchCollection GetAllCurrency(string url)
        {
            MatchCollection items = Regex.Matches(url, $"<Valute ID=\"(.*?)\">");
            return items;
        }

        void GetHoroscope(string zodiak)
        {
           WebClient wc = new WebClient();
           richTextBoxHoroscope.Text = Regex.Match(wc.DownloadString($"https://1001goroskop.ru/" + zodiak), $"<div itemprop=\"description\"><p>(.*?)</p></div>").Groups[1].Value;
        }

        class Zodiak
        {
            public string Name { get; set; }
            public string Link { get; set; }
        }

        private void comboBoxZodiak_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetHoroscope(comboBoxZodiak.SelectedValue.ToString());
            richTextBoxHoroscope.SelectAll();
            richTextBoxHoroscope.SelectionAlignment = HorizontalAlignment.Center;
        }

        private Point mouseOffset;
        private bool isMouseDown = false;

        private void Widget_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Widget_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Widget_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = false;
        }
    }
}
