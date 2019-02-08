using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationObjects.BO
{
    public class SuggestionsBO
    {
        public int Usefullness { get; set; }
        public int Satisfaction { get; set; }
        public int EaseOfUse { get; set; }
        public int LookAndFeel { get; set; }
        public string Feedback { get; set; }
        public string IP { get; set; }
    }
}
