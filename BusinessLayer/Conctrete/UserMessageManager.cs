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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void Delete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
           return _userMessageDal.GetList();
        }

        public void Insert(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void Uptade(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetList()
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }
    }
}
