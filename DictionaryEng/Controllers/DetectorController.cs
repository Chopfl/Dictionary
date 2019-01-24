using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    static class DetectorController
    {
        public static void DetectorIndex()
        {
            DetectorViews detectorViews = new DetectorViews();
            detectorViews.ShowDetectorIndex();
        }

        public static void DetectLanguage(String textToDetected)
        {
            String language;
            DetectorViews detectorViews = new DetectorViews();

            if (textToDetected == null)
            {
                detectorViews.ShowDetectorIndex();
            }

            LanguageDetectorClass lang = new LanguageDetectorClass(textToDetected);
            lang.Detect();
            language = lang.GetFullNameLanguage();

            detectorViews.ShowDetectedLanguage(language, textToDetected);
        }
    }
}
