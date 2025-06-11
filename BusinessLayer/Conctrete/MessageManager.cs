using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conctrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }

        public List<Message> GetMessagesWithUserService()
        {
            return _messagedal.GetList();
        }

        public void TAdd(Message t)
        {
            _messagedal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messagedal.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _messagedal.GetByID(id);
        }

        public List<Message> TGetlist()
        {
            return _messagedal.GetList();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
