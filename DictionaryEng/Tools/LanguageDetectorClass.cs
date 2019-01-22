using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DictionaryEng
{
    class LanguageDetectorClass
    {
        public String TextToDetected { get; set; }
        private String API_KEY;
        private String API_LINK_DETECTOR = "https://translate.yandex.net/api/v1.5/tr/detect?key=<APIkey>&text=";
        public String DetectedLanguage { get; set; }

        public LanguageDetectorClass( String TextToDetected )
        {
            this.TextToDetected = TextToDetected;
            API_KEY = SettingsClass.API_KEY;
            API_LINK_DETECTOR = "https://translate.yandex.net/api/v1.5/tr/detect?key="+ API_KEY +"&text=";
        }

        public void Detect()
        {
            DetectedLanguage =  ApiDetectorStart(TextToDetected);
        }

        public String GetFullNameLanguage()
        {
            return ConvertNameLanguage();
        }

        private String ApiDetectorStart(String TextDetected)
        {
            String language = null;
            try
            {
                WebClient client = new WebClient();
                Byte[] pageData = client.DownloadData(API_LINK_DETECTOR + TextDetected);
                String xmlResponse = Encoding.ASCII.GetString(pageData);

                language = getBetween(xmlResponse, "lang=\"", "\" />");
            }
            catch (WebException webEx)
            {
                Console.WriteLine(webEx.ToString());
                if (webEx.Status == WebExceptionStatus.ConnectFailure)
                {
                    Console.WriteLine("Najprawdopodobniej zapora systemowa zakłóciła działanie programu");
                }
            }

            return language;
        }

        private string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        private String ConvertNameLanguage()
        {
            switch (DetectedLanguage)
            {
                case "pl":
                    return "Polish";
                case "eng":
                    return "English";
                default:
                    return "Nie wykryto";
                    break;
            }
        }
    }
}
