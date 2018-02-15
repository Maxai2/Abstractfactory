using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
namespace Proxy
{
    interface IProxy
    {
        string Translate(string word);
    }

    class Proxy : IProxy
    {
        static Dictionary<string, string> dictionary;

        Translator translator;

        public Proxy()
        {
            dictionary = new Dictionary<string, string>();
            translator = new Translator();

            if (dictionary == null)
            {
                using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    dictionary = (Dictionary<string, string>)formatter.Deserialize(fs);
                }
            }
            else
            {
                dictionary.Add("привет", "hello");
                dictionary.Add("кошка", "cat");
                dictionary.Add("собака", "dog");
                dictionary.Add("слон", "elephant");
                dictionary.Add("пока", "bye");
            }
        }

        public void Serialize()
        {
            using (FileStream fs = new FileStream("dictionary.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fs, dictionary);
            }
        }

        public string Translate(string word)
        {
            if (!dictionary.ContainsKey(word))
                dictionary.Add(word, translator.Translate(word));

            return dictionary[word];
        }
    }

    class Translator : IProxy
    {
        public string Translate(string Rword)
        {
            using (WebClient webClient = new WebClient())
            {
                var uri = new Uri($@"https://translate.yandex.net/api/v1.5/tr.json/translate?lang=ru-en&key=trnsl.1.1.20180215T075947Z.541acd65df4bd709.eb8bd41e400f30b878ac4cfeae2a82dd55923be0&text=" + Rword);

                var data = webClient.DownloadString(uri);

                dynamic obj = JObject.Parse(data);

                string temp = Convert.ToString(obj.text);

                temp = temp.Substring(6);

                temp = temp.Remove(temp.IndexOf('"'));

                return temp;
            }
        }
    }
}
//--------------------------------------