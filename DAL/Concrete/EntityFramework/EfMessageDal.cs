using DAL.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EntityFramework
{
    public class EfMessageDal : IMessageDal
    {
        public void Add(Message message)
        {
            using (WebChatContext context=new WebChatContext())
            {
                var addedEntity = context.Entry(message);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Message message)
        {
            using (WebChatContext context = new WebChatContext())
            {
                var deletedEntity = context.Entry(message);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Message> GetAll()
        {
            using (WebChatContext context = new WebChatContext())
            { 
                return context.Set<Message>().ToList(); 
            }
        }

        public void Update(Message message)
        {
            using (WebChatContext context = new WebChatContext())
            {
                var updatedEntity = context.Entry(message);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
