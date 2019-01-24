using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    static class DetectorController
    {
        //Akcja widoku index detektor w kontrolerze detektor
        public static void DetectorIndex()
        {
            DetectorViews detectorViews = new DetectorViews();
            detectorViews.ShowDetectorIndex();
        }

        //Akcja detekcji jezyka w kontrolerze detektor
        public static void DetectLanguage(String textToDetected)
        {
            String language;
            DetectorViews detectorViews = new DetectorViews();

            //W przypadku akcji detekcji w widoku sprawdzonego jezyka, nie sprawdza jeszcze raz tylko przelacza na widok indexu
            if (textToDetected == null)
            {
                detectorViews.ShowDetectorIndex();
            }

            //Klasa odpowiedzialna za sprawdzenie jezyka
            LanguageDetectorClass lang = new LanguageDetectorClass(textToDetected);
            lang.Detect();
            language = lang.GetFullNameLanguage();

            detectorViews.ShowDetectedLanguage(language, textToDetected);
        }
    }
}
