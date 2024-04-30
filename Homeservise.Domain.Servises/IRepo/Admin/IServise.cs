using Homeservise.Domain.core.Servises.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.Servises.IRepo.Admin
{
    public interface IServise
    {
        public void CreateServise(CreateServiseDto createServiseDto);
        public List<ShowserviseDtos> GetAllservise();
        public ShowserviseDtos ShowDetailsServise(int id);
        public void UpdateServises(int id, CreateServiseDto createServiseDto);
    }
}
