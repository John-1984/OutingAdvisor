using ApplicationObjects.BO;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementation
{
    public class SuggestionsBL : ISuggestions
    {

        public DataLayer.Implementation.SuggestionsDL _suggestionsDL;
        public SuggestionsBL()
        {
            _suggestionsDL = new DataLayer.Implementation.SuggestionsDL();
        }

        public string SaveSuggestions(SuggestionsBO suggestion)
        {
            return _suggestionsDL.SaveSuggestions(suggestion);
        }
    }
}
