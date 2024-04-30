using Homeservise.Domain.core.Servises.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.Servises.IRepo.Admin
{
    public interface ISubServises
    {
        public void CreateSubServise(SubServiseDto subServiseDto);
        public List<SubServiseDto> GetAllSubservise();
        public SubServiseDto ShowDetailsSubServise(int id);
        public void DeleteSubServise(int id);
        public void UpdateServises(int id, SubServiseDto subServiseDto);
    }
}
