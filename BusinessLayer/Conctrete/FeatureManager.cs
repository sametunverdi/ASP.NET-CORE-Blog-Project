﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Conctrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> TGetlist()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Uptade(t);
        }
    }
}
