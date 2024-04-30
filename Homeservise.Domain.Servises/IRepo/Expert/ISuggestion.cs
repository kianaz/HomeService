using Homeservise.Domain.core.Action.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.Servises.IRepo.Expert
{
    public interface ISuggestion
    {
        public void CreaSuggest(SuggestionDto suggestionDto);
        public List<SuggestionDto> GetAllSuggestion();
        public SuggestionDto ShowDetailsSuggestion(int id);
        public void DeleteSuggestion(int id);
        public void Updaterequest(int id, SuggestionDto suggestionDto);
    }
}
