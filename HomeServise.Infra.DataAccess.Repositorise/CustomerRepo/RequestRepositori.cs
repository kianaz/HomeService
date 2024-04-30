using Azure.Core;
using HomeService.Infra.DBcontaxt.EF.SQL.DBcontextSet;
using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Action.Dtos;
using Homeservise.Domain.core.Action.Entiti;
using Homeservise.Domain.core.Servises.Dtos;
using Homeservise.Domain.core.Servises.Entiti;
using Homeservise.Domain.Servises.IRepo.Customer;

namespace HomeServise.Infra.DataAccess.Repositorise.CustomerRepo
{
    public class RequestRepositori(HomeServiceDbcontaxt homeService): IRequest
    {
        private HomeServiceDbcontaxt _dBcontaxt;

        #region RequestCRUD
        public void Createrequest(CreaterequestDTO createrequestDTO)
        {
            var target = new Homeservise.Domain.core.Action.Entiti.Request();
            if (createrequestDTO != null)
            {
                createrequestDTO.Titel = target.Titel;
                createrequestDTO.Describtion = target.Describtion;
                createrequestDTO.LocationCity = target.Location.Select(x => x.City).ToString();
                createrequestDTO.LocationProvinc= target.Location.Select(x => x.Province).ToString();
                createrequestDTO.LocationCity=target.Location.Select(x => x.Address).ToString();
                createrequestDTO.Pictures=target.Pictures.Select(x => x.PictureUrl).ToList();
         
            }

            _dBcontaxt.Add(target);
            _dBcontaxt.SaveChanges();
        }
        public List<CreaterequestDTO> GetAllsRequest()
        {
            var result = _dBcontaxt.Requests
               .Select(x => new CreaterequestDTO
               {
                   Titel = x.Titel,
                   Describtion = x.Describtion
               }).ToList();
            return result;

        }
        public Homeservise.Domain.core.Action.Entiti.Request GetRequestById(int id)
        {
            return _dBcontaxt.Requests.FirstOrDefault(b => b.Id == id);
        }
        public void DeleteServise(int id)
        {
            var result = GetRequestById(id);
            if (result != null)
            {
                _dBcontaxt.Requests.Remove(result);
            }
            _dBcontaxt.SaveChanges();
        }
        public CreaterequestDTO ShowDetailsRequest(int id)
        {

            var result = _dBcontaxt.Requests
              .Select(x => new CreaterequestDTO
              {
                  Id=x.Id,
                  Titel = x.Titel,
                  Describtion = x.Describtion,
                  LocationCity=x.Location.Select(x => x.City).ToString(),
                  LocationProvinc=x.Location.Select(x => x.Province).ToString(),
                  Adress= x.Location.Select(x => x.Address).ToString(),
                  Pictures = x.Pictures.Select(x => x.PictureUrl).ToList()
              }).FirstOrDefault(x => x.Id == id);

            return result;
        }
        public void Updaterequest(int id, CreaterequestDTO createrequestDTO)
        {
            if (createrequestDTO.Id == id)
            {
                var result = GetRequestById(id);
                if (result.Id == createrequestDTO.Id)
                {
                     createrequestDTO.Titel = result.Titel;
                    createrequestDTO.Describtion = result.Describtion;
                    createrequestDTO.LocationCity = result.Location.Select(x => x.City).ToString();
                    createrequestDTO.LocationProvinc = result.Location.Select(x => x.Province).ToString();
                    createrequestDTO.LocationCity = result.Location.Select(x => x.Address).ToString();
                    createrequestDTO.Pictures = result.Pictures.Select(x => x.PictureUrl).ToList();
                }
                _dBcontaxt.SaveChanges();
            }

        }
        #endregion
        

    }
}
