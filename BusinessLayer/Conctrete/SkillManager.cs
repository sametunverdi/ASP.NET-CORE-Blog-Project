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
    public class SkillManager: ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TAdd(Service t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill t)
        {
           _skillDal.Delete(t);
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetByID(id);
        }

        public List<Skill> TGetlist()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Uptade(t);
        }

        Service IGenericService<Service>.TGetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Service> IGenericService<Service>.TGetlist()
        {
            throw new NotImplementedException();
        }
    }
}
