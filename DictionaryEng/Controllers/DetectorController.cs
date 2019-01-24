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
    }
}
