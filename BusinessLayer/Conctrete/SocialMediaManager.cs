﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conctrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetlist()
        {
           return _socialMediaDal.GetList();
        }

        public void TUpdate(SocialMedia t)
        {
           _socialMediaDal.Uptade(t);
        }
    }
}
