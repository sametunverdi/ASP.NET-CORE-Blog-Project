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
    public class PortfolioManager: IPortfolioService
    {
        IPortfolioDal _Iportfoliodal;

        public PortfolioManager(IPortfolioDal ıportfoliodal)
        {
            _Iportfoliodal = ıportfoliodal;
        }

        public void TAdd(Portfolio t)
        {
            _Iportfoliodal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _Iportfoliodal.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
            return _Iportfoliodal.GetByID(id);
        }

        public List<Portfolio> TGetlist()
        {
           return _Iportfoliodal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _Iportfoliodal.Uptade(t);
        }
    }
}
