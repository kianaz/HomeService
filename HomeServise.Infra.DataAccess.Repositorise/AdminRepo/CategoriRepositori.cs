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
    public class CategoriRepositori(HomeServiceDbcontaxt homeService): ICategory
    {
        private HomeServiceDbcontaxt _dBcontaxt;
        #region CategoriCRUD
        public void CreateCategori(CategoriDto categoriDto)
        {
            var target = new Category();
            if (categoriDto != null)
            {
                categoriDto.Name = target.Name;
                categoriDto.PictureUrl = target.Picture.PictureUrl;
            }

            _dBcontaxt.Add(target);
            _dBcontaxt.SaveChanges();
        }
        public List<CategoriDto> GetAllCategory()
        {
            var result = _dBcontaxt.categories
               .Select(x => new CategoriDto
               {
                   Name = x.Name,
               }).ToList();
            return result;

        }
        public Category GetCategoribyId(int id)
        {
            return _dBcontaxt.categories.FirstOrDefault(b => b.Id == id);
        }
        public void Deletecategori(int id)
        {
            var result = GetCategoribyId(id);
            if (result != null)
            {
                _dBcontaxt.categories.Remove(result);
            }
            _dBcontaxt.SaveChanges();
        }
        public void UpdateCategoris(int id, CategoriDto categoriDto)
        {
            if (categoriDto.Id == id)
            {
                var result = GetCategoribyId(id);
                if (result.Id == categoriDto.Id)
                {
                    categoriDto.Name = result.Name;
                    categoriDto.PictureUrl = result.Picture.PictureUrl;
                }
                _dBcontaxt.SaveChanges();
            }

        }
        #endregion
    }
}
