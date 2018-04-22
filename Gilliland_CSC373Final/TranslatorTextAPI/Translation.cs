using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace TranslatorTextAPI
{
    public class Translation
    {
        private string baseUri = "https://api.microsofttranslator.com";
        private string path = "/V2/Http.svc/Translate";
        private string apiKey = "8669ebe0a8104b109684aa82f14aa212";
        private string results = "";
        private HttpClient client;
        private dynamic queryString;

        public Translation()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            queryString = HttpUtility.ParseQueryString(string.Empty);
        }
        /// <summary>
        /// Take a string and language code 
        /// Convert to that language
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<string> TranslateText(KeyValuePair<string, string> args)
        {
            //Add k/v pair to list in case of multiple values 
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>()
            {
                args
            };
            //iterate through list of items being translated 
            foreach (KeyValuePair<string, string> i in list)
            {
                //Build the url with the language and string data
                string uri = baseUri + path + "?to=" + i.Value + "&text=" + System.Net.WebUtility.UrlEncode(i.Key);
                HttpResponseMessage response = await client.GetAsync(uri); //hand to endpoint
                string result = await response.Content.ReadAsStringAsync(); //read back results
                var content = XElement.Parse(result).Value; //pull string out of response 
                results = content;
            }
            return results;

        }

    }
}
