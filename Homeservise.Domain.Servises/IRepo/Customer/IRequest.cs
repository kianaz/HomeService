using Homeservise.Domain.core.Action.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.Servises.IRepo.Customer
{
    public interface IRequest
    {
        public void Createrequest(CreaterequestDTO createrequestDTO);
        public List<CreaterequestDTO> GetAllsRequest();
        public void DeleteServise(int id);
        public CreaterequestDTO ShowDetailsRequest(int id);

    }
}
