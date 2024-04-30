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
    public class ServiseRepositori(HomeServiceDbcontaxt homeService): IServise
    {
        private HomeServiceDbcontaxt _dBcontaxt;
        #region ServiseCRUD
        public void CreateServise(CreateServiseDto createServiseDto)
        {
            var target = new Servise();
            if (createServiseDto != null)
            {
                createServiseDto.Titel = target.Titel;
                createServiseDto.CategoriName = target.Category.Name;
                createServiseDto.CategoryId = target.CategoryId;
            }

            _dBcontaxt.Add(target);
            _dBcontaxt.SaveChanges();
        }
        public List<ShowserviseDtos> GetAllservise()
        {
            var result = _dBcontaxt.servises
               .Select(x => new ShowserviseDtos
               {
                   Id = x.Id,
                   Titel = x.Titel,
                   CategoriName = x.Category.Name
               }).ToList();
            return result;

        }
        public Servise GetservisbyId(int id)
        {
            return _dBcontaxt.servises.FirstOrDefault(b => b.Id == id);
        }
        public void DeleteServise(int id)
        {
            var result = GetservisbyId(id);
            if (result != null)
            {
                _dBcontaxt.servises.Remove(result);
            }
            _dBcontaxt.SaveChanges();
        }
        public ShowserviseDtos ShowDetailsServise(int id)
        {

            var result = _dBcontaxt.servises
              .Select(x => new ShowserviseDtos
              {
                  Id = x.Id,
                  Titel = x.Titel,
                  CategoriName = x.Category.Name
              }).FirstOrDefault(x => x.Id == id);

            return result;
        }
        public void UpdateServises(int id, CreateServiseDto createServiseDto)
        {
            if (createServiseDto.Id == id)
            {
                var result = GetservisbyId(id);
                if (result.Id == createServiseDto.Id)
                {
                    createServiseDto.Titel = result.Titel;
                    createServiseDto.CategoriName = result.Category.Name;
                    createServiseDto.CategoryId = result.CategoryId;
                }
                _dBcontaxt.SaveChanges();
            }

        }
        #endregion
    }
}
