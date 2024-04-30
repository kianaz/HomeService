using Homeservise.Domain.core.Action.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.Servises.IRepo.Customer
{
    public interface IComment
    {
        public void CreateComment(CommentDto commentDto);
        public List<CommentDto> GetAllsComment();
    }
}
