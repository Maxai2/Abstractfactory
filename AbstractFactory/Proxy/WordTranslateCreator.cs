using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
//--------------------------------------
namespace Proxy
{
    static class WordTranslateCreator
    {
        private static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public static Dictionary<string, string> GetDictionary() => dictionary;

        public static string GetWord(string Rword)
        {
            dictionary.Add("привет", "hello");
            dictionary.Add("кошка", "cat");
            dictionary.Add("собака", "dog");
            dictionary.Add("слон", "elephant");
            dictionary.Add("пока", "bye");

            string Eword = "";

            if (dictionary.ContainsKey(Rword))
                Eword = Rword;
            else
            {
                using (WebClient webClient = new WebClient())
                {
                    var uri = new Uri($@"https://translate.yandex.net/api/v1.5/tr.json/translate?lang=ru-en&key=trnsl.1.1.20180215T075947Z.541acd65df4bd709.eb8bd41e400f30b878ac4cfeae2a82dd55923be0&text=" + Rword); 

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