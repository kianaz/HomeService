using Homeservise.Domain.core.Servises.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.Servises.IRepo.Admin
{
    public interface ICategory
    {
        public void CreateCategori(CategoriDto categoriDto);
        public List<CategoriDto> GetAllCategory();
        public void UpdateCategoris(int id, CategoriDto categoriDto);
    }
}
