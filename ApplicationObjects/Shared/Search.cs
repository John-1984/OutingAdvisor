using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationObjects.Shared
{
    public class Search
    {
        public IList<MasterListItem> StateList { get; set; }

        public IList<MasterListItem> LocationList { get; set; }

        public string SelectedState { get; set; }

        public string SelectedLocation { get; set; }
    }
}
