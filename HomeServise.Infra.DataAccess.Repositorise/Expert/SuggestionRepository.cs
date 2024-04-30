using HomeService.Infra.DBcontaxt.EF.SQL.DBcontextSet;
using Homeservise.Domain.core.Action.Dtos;
using Homeservise.Domain.core.Action.Entiti;
using Homeservise.Domain.Servises.IRepo.Expert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServise.Infra.DataAccess.Repositorise.Expert
{
    public class SuggestionRepository(HomeServiceDbcontaxt homeService): ISuggestion
    {
        private HomeServiceDbcontaxt _dBcontaxt;
        #region SuggestionCRUD
        public void CreaSuggest(SuggestionDto suggestionDto)
        {
            var target = new Sugestion();
            if (suggestionDto != null)
            {
                suggestionDto.Titel = target.Titel;
                suggestionDto.Describtion = target.Describtion;
                suggestionDto.Price = target.Price;
            }

            _dBcontaxt.Add(target);
            _dBcontaxt.SaveChanges();
        }
        public List<SuggestionDto> GetAllSuggestion()
        {
            var result = _dBcontaxt.Sugestions
               .Select(x => new SuggestionDto
               {
                   Titel = x.Titel,
                   Describtion = x.Describtion,
                   Price=x.Price
               }).ToList();
            return result;
        }
        public Sugestion GetSuggestionById(int id)
        {
            return _dBcontaxt.Sugestions.FirstOrDefault(b => b.Id == id);
        }
        public void DeleteSuggestion(int id)
        {
            var result = GetSuggestionById(id);
            if (result != null)
            {
                _dBcontaxt.Sugestions.Remove(result);
            }
            _dBcontaxt.SaveChanges();
        }
        public SuggestionDto ShowDetailsSuggestion(int id)
        {
            var result = _dBcontaxt.Sugestions
              .Select(x => new SuggestionDto
              {
                  Id = x.Id,
                  Titel = x.Titel,
                  Describtion = x.Describtion,
                  IsAcceptByCustomer=x.IsAcceptByCustomer,
                  SuggestionStatus=x.SuggestionStatus,
                  Price=x.Price,
                  RequestsTitel=x.Requests.Titel
              }).FirstOrDefault(x => x.Id == id);

            return result;
        }
        public void Updaterequest(int id, SuggestionDto suggestionDto)
        {
            if (suggestionDto.Id == id)
            {
                var result = GetSuggestionById(id);
                if (result.Id == suggestionDto.Id)
                {
                    suggestionDto.Titel = result.Titel;
                    suggestionDto.Describtion = result.Describtion;
                    suggestionDto.Price = result.Price;
                }
                _dBcontaxt.SaveChanges();
            }
        }
        #endregion
    }
}
