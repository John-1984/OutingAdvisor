using ApplicationObjects.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface ISuggestions
    {
        string SaveSuggestions(SuggestionsBO suggestion);
    }
}
