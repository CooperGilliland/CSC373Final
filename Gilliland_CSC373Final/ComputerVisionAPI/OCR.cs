using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ByteConverter;
using Newtonsoft.Json;

namespace ComputerVisionAPI
{
    public class OCR
    {
        private string baseUri = "https://westus.api.cognitive.microsoft.com/vision/v1.0/ocr?";
        private string apiKey = "058d169299344d6397912baa7e70cb21";
        private HttpClient client;
        private dynamic queryString;
        private string results = "";
        private string output = "";

        public OCR()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            queryString = HttpUtility.ParseQueryString(string.Empty);
        }
        /// <summary>
        /// Take the optical characters from an image 
        /// put them in a string
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public async Task<string> ConvertToText(string filePath)
        {
            //define the parameters needed by the API
            queryString["language"] = "unk";
            queryString["detectOrientation "] = "true";
            var fullUri = baseUri + queryString; //Define the endpoint
            //Convert the chosen image to a byte array 
            byte[] imgBytes = ImageConverter.ImageToByteArray(filePath);
            using (var content = new ByteArrayContent(imgBytes)) //Broadcast the byte array 
            {
                //Define the content being broadcast 
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                HttpResponseMessage response = await client.PostAsync(fullUri, content); //Collect the response from the endpoint 
                results = await response.Content.ReadAsStringAsync(); //Collect the string from the endpoint response
            }
            output = ExtractString(results); //Extract only the desired information from the response
            return output; //return the collected characters
        }
        /// <summary>
        /// Extract the string results from the larger JSON
        /// </summary>
        /// <param name="JsonResults"></param>
        /// <returns></returns>
        private string ExtractString(dynamic JsonResults)
        {
            //Deserialize the json from the arguement 
            dynamic dynamDeserializeObjectJson = JsonConvert.DeserializeObject(JsonResults);
            string res = "";
            //iterate through the specific region of the deserialized json
            foreach (var lines in dynamDeserializeObjectJson.regions)
            {
                try
                {
                    //iterate through the next layer
                    foreach (var words in lines.lines)
                    {
                        //iterate through the layer that has the desired data 
                        foreach (var text in words.words)
                        {
                            //Copy the desired data into a string with spaces 
                            res += " " + text.text;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    // throw;
                }
            }
            //Return the desired data 
            return res;
        }
    }
}
