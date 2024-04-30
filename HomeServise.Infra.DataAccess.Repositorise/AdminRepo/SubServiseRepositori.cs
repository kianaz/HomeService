using HomeService.Infra.DBcontaxt.EF.SQL.DBcontextSet;
using Homeservise.Domain.core.Servises.Dtos;
using Homeservise.Domain.core.Servises.Entiti;
using Homeservise.Domain.Servises.IRepo.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServise.Infra.DataAccess.Repositorise.AdminRepo
{
    public class SubServiseRepositori(HomeServiceDbcontaxt homeService): ISubServises
    {
        private HomeServiceDbcontaxt _dBcontaxt;
        #region ServiseCRUD
        public void CreateSubServise(SubServiseDto subServiseDto)
        {
            var target = new Subservises();
            if (subServiseDto != null)
            {
                subServiseDto.Titel = target.Titel;
                subServiseDto.Describtion = target.Describtion;
                subServiseDto.MinPrice = target.MinPrice;
              
            }
            _dBcontaxt.Add(target);
            _dBcontaxt.SaveChanges();
        }


        public List<SubServiseDto> GetAllSubservise()
        {
            var result = _dBcontaxt.subservises
               .Select(x => new SubServiseDto
               {
                   Titel = x.Titel,
               }).ToList();
            return result;

        }


        public Subservises GetSubservisbyId(int id)
        {
            return _dBcontaxt.subservises.FirstOrDefault(b => b.Id == id);
        }


        public void DeleteSubServise(int id)
        {
            var result = GetSubservisbyId( id);
            if (result != null)
            {
                _dBcontaxt.subservises.Remove(result);
            }
            _dBcontaxt.SaveChanges();
        }


        public SubServiseDto ShowDetailsSubServise(int id)
        {

            var result = _dBcontaxt.subservises
              .Select(x => new SubServiseDto
              {
                  Id = x.Id,
                  Titel = x.Titel,
                  Describtion=x.Describtion,
                  MinPrice=x.MinPrice

              }).FirstOrDefault(x => x.Id == id);

            return result;
        }
        public void UpdateServises(int id,SubServiseDto subServiseDto)
        {
            if (subServiseDto.Id == id)
            {
                var result = GetSubservisbyId(id);
                if (result.Id == subServiseDto.Id)
                {
                    subServiseDto.Titel = result.Titel;
                    subServiseDto.Describtion = result.Describtion;
                    subServiseDto.MinPrice = result.MinPrice;
                }
                _dBcontaxt.SaveChanges();
            }

        }
        #endregion
    }
}
