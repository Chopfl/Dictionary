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
                case "en":
                    return "English";
                case "az":
                    return "Azerbaijan";
                case "sq":
                    return "Albanian";
                case "am":
                    return "Amharic";
                case "ar":
                    return "Arabic";
                case "hy":
                    return "Armenian";
                case "af":
                    return "Afrikaans";
                case "ue":
                    return "Basque";
                case "ba":
                    return "Bashkir";
                case "be":
                    return "Belarusian";
                case "bn":
                    return "Bengali";
                case "my":
                    return "Burmese";
                case "bg":
                    return "Bulgarian";
                case "bs":
                    return "Bosnian";
                case "cy":
                    return "Welsh";
                case "hu":
                    return "Hungarian";
                case "vi":
                    return "Vietnamese";
                case "nl":
                    return "Dutch";
                case "gl":
                    return "Galician";
                case "ht":
                    return "Haitian (Creole)";
                case "el":
                    return "Greek";
                case "ka":
                    return "Georgian";
                case "gu":
                    return "Gujarati";
                case "da":
                    return "Danish";
                case "he":
                    return "Hebrew";
                case "yi":
                    return "Yiddish";
                case "id":
                    return "Indonesian";
                case "ga":
                    return "Irish";
                case "it":
                    return "Italian";
                case "is":
                    return "Icelandic";
                case "es":
                    return "Spanish";
                case "kk":
                    return "Kazakh";
                case "kn":
                    return "Kannada";
                case "ca":
                    return "Catalan";
                case "ky":
                    return "Kyrgyz";
                case "zh":
                    return "Chinese";
                case "ko":
                    return "Korean";
                case "km":
                    return "Khmer";
                case "lo":
                    return "Laotian";
                case "lv":
                    return "Latvian";
                case "lt":
                    return "Lithuanian";
                case "lb":
                    return "Luxembourgish";
                case "mk":
                    return "Macedonian";
                case "mn":
                    return "Mongolian";
                case "de":
                    return "German";
                case "ne":
                    return "Nepali";
                case "no":
                    return "Norwegian";
                case "fa":
                    return "Persian";
                case "pt":
                    return "Portuguese";
                case "ro":
                    return "Romanian";
                case "ru":
                    return "Russian";
                case "sr":
                    return "Serbian";
                case "sk":
                    return "Slovakian";
                case "sl":
                    return "Slovenian";
                case "sw":
                    return "Swahili";
                case "th":
                    return "Thai";
                case "tr":
                    return "Turkish";
                case "fi":
                    return "Finnish";
                case "fr":
                    return "French";
                case "hi":
                    return "Hindi";
                case "cs":
                    return "Czech";
                case "sv":
                    return "Swedish";
                case "ja":
                    return "Japanese";
                default:
                    return "Nie wykryto";
                    break;
            }
        }
    }
}
