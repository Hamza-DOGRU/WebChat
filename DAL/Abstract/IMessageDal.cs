using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IMessageDal
    {
        List<Message> GetAll();
        void Add(Message message);
        void Delete(Message message);
        void Update(Message message); 
    }
}
