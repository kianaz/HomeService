using HomeService.Infra.DBcontaxt.EF.SQL.DBcontextSet;
using Homeservise.Domain.core.Action.Dtos;
using Homeservise.Domain.core.Action.Entiti;
using Homeservise.Domain.Servises.IRepo.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServise.Infra.DataAccess.Repositorise.CustomerRepo
{
    public class CommentRepositori(HomeServiceDbcontaxt homeService): IComment
    {
        private HomeServiceDbcontaxt _dBcontaxt;
        #region CommentCRUD
        public void CreateComment(CommentDto commentDto)
        {
            var target = new Comment();
            if (commentDto != null)
            {
                commentDto.Text = target.Text;
                commentDto.Createdtime = target.Createdtime;
                commentDto.CustomerName = target.Customer.Username;
            }

            _dBcontaxt.Add(target);
            _dBcontaxt.SaveChanges();
        }
        public List<CommentDto> GetAllsComment()
        {
            var result = _dBcontaxt.Comments
               .Select(x => new CommentDto
               {
                   Text = x.Text,
                   Createdtime = x.Createdtime,
                   CustomerName = x.Customer.Username

               }).ToList();
            return result;

        }

        #endregion
    }
}
