using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
//--------------------------------------
namespace Proxy
{
    class WordTranslateCreator
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        

        public string GetWord(string Rword)
        {
            string Eword = "";

            if (dictionary.ContainsKey(Rword))
                Eword = Rword;
            else
            {
                using (WebClient webClient = new WebClient())
                {
                    var uri = new Uri($@"https://translate.yandex.net/api/v1.5/tr.json/translate?lang=ru-en&key=trnsl.1.1.20180215T075947Z.541acd65df4bd709.eb8bd41e400f30b878ac4cfeae2a82dd55923be0&text=слон"); // &text=Hello%20World! &HTTP/1.1&text=
                    uri = uri.AddParameter("text", Rword);

                    //var uriOrgin = uri.Query + Rword;

                    var data = webClient.DownloadString(uri);

                    dynamic obj = JObject.Parse(data);

                    string temp = Convert.ToString(obj.text);

                    temp = temp.Substring(6);

                    temp = temp.Remove(temp.IndexOf('"'));

                    Eword = temp;

                    dictionary.Add(Rword, Eword);
                }
            }

            return Eword;
        }
    }
}
//--------------------------------------