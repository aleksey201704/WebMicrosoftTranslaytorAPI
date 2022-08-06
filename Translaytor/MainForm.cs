using System;
//using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using Newtonsoft.Json;
//using RestSharp;

namespace Translaytor
{

    public partial class MainForm : Form
    {
       /* const string RUSWord = "-.,!? йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
        const string ENGWord = "-.,!? qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
       */
        public string BodyText { get; set; } = "";
        public int count { get; set; } = 0;

        enum Lang {en,de,it,ru};

        public class DetectedLanguage
        {
            public string language { get; set; }
            public double score { get; set; }
        }

        public class Root
        {
            public DetectedLanguage detectedLanguage { get; set; } = new DetectedLanguage();
            public List<Translation> translations { get; set; } = new List<Translation>();
        }

        public class Translation
        {
            public string text { get; set; } 
            public string to { get; set; }
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            BodyText = "";
            
            foreach (var item in rTexBoxTop.Lines) BodyText += item + " ";

            API_MICROSOFT(BodyText);

        }

        private void rTexBoxTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            count++;
            if (rTexBoxTop.Focus() && count == 1) rTexBoxTop.Text = "";
            rTexBoxTop.ForeColor = System.Drawing.Color.Black;
        }

        private async void API_MICROSOFT(string TextMain)
        {
            string urlbody = $"https://microsoft-translator-text.p.rapidapi.com/BreakSentence?api-version=3.0";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(urlbody),
                Headers =
    {
        { "X-RapidAPI-Key", "a11c0f76b1msha96353bc2cd475ap16faacjsncc402d752f11" },
        { "X-RapidAPI-Host", "microsoft-translator-text.p.rapidapi.com" },
    },
                Content = new StringContent("[\r{\r\"Text\": \" " + TextMain + "\"\r}\r]")

                {
                    Headers =

        {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
                }
            };

            var response = await client.SendAsync(request);
            string body = await response.Content.ReadAsStringAsync();
           
            string t = body.Substring(1, body.Length - 2);
            var result = System.Text.Json.JsonSerializer.Deserialize<Root>(t);
            interpreter(TextMain, result.detectedLanguage.language);
        }
        private async void interpreter(string textmain,string l)
        {

            if (l == "ru" && rdButtonEng.Checked) l = Lang.en.ToString();
            if (l == "ru" && rdButtonGer.Checked) l = Lang.de.ToString();
            if (l == "ru" && rdButtonIta.Checked) l = Lang.it.ToString();

            if (l == "en" && rdButtonRU.Checked) l = Lang.ru.ToString();
            if (l == "en" && rdButtonGer.Checked) l = Lang.de.ToString();
            if (l == "en" && rdButtonIta.Checked) l = Lang.it.ToString();


            string urlbody = $"https://microsoft-translator-text.p.rapidapi.com/translate?to%5B0%5D={l}&api-version=3.0&profanityAction=NoAction&textType=plain";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                 RequestUri = new Uri(urlbody),
                Headers =
    {
        { "X-RapidAPI-Key", "a11c0f76b1msha96353bc2cd475ap16faacjsncc402d752f11" },
        { "X-RapidAPI-Host", "microsoft-translator-text.p.rapidapi.com" },
    },
                Content = new StringContent("[\r{\r\"Text\": \" " + textmain + "\"\r}\r]")

                {
                    Headers =

        {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
                }
            };

            var response = await client.SendAsync(request);
            string body = await response.Content.ReadAsStringAsync();
                        
            for (int i = 0; i < response.ToString().Length-10; i++)
            {
                if (response.ToString().Substring(i, 9) == "Remaining")
                {
                    lblinfo.Text ="Осталось количество символов в этом месяце"+ response.ToString().Substring(i + 9, 10);
                }
            }

            
            string t = body.Substring(1, body.Length - 2);
            var result = System.Text.Json.JsonSerializer.Deserialize<Root>(t);

            foreach (var item in result.translations)
            {
                richTextBox2.Text = item.text;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string l = "en";
            string textmain = "Привет";
            string urlbody = $"https://microsoft-translator-text.p.rapidapi.com/translate?to%5B0%5D={l}&api-version=3.0&profanityAction=NoAction&textType=plain";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(urlbody),
                Headers =
    {
        { "X-RapidAPI-Key", "a11c0f76b1msha96353bc2cd475ap16faacjsncc402d752f11" },
        { "X-RapidAPI-Host", "microsoft-translator-text.p.rapidapi.com" },
    },
                Content = new StringContent("[\r{\r\"Text\": \" " + textmain + "\"\r}\r]")

                {
                    Headers =

        {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
                }
            };

            var response = await client.SendAsync(request);
            string body = await response.Content.ReadAsStringAsync();

            
            /*string t = body.Substring(1, body.Length - 2);
            var result = System.Text.Json.JsonSerializer.Deserialize<Root>(t);

            foreach (var item in result.translations)
            {
                richTextBox2.Text = item.text;
            }*/
        }

        private void rdButtonEng_CheckedChanged(object sender, EventArgs e)
        {
            if (rdButtonEng.Checked) API_MICROSOFT(rTexBoxTop.Text);
        }

        private void rdButtonGer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdButtonGer.Checked) API_MICROSOFT(rTexBoxTop.Text);
        }

        private void rdButtonIta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdButtonIta.Checked) API_MICROSOFT(rTexBoxTop.Text);
        }

        private void rdButtonRU_CheckedChanged(object sender, EventArgs e)
        {
            if (rdButtonRU.Checked) API_MICROSOFT(rTexBoxTop.Text);
        }
    }
}
