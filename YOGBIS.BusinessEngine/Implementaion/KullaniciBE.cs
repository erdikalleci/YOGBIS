﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YOGBIS.BusinessEngine.Contracts;
using YOGBIS.Common.ConstantsModels;
using YOGBIS.Common.ResultModels;
using YOGBIS.Common.VModels;
using YOGBIS.Data.Contracts;
using YOGBIS.Data.DbModels;

namespace YOGBIS.BusinessEngine.Implementaion
{
    public class KullaniciBE : IKullaniciBE
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public KullaniciBE(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Result<List<KullaniciVM>> GetAllKullanici()
        {
            var data = _unitOfWork.kullaniciRepository.GetAll().ToList();
            var kullanicilar = _mapper.Map<List<Kullanici>, List<KullaniciVM>>(data);
            return new Result<List<KullaniciVM>>(true, ResultConstant.RecordFound, kullanicilar);
        }

        public Result<KullaniciVM> GetAllKullanici(int id)
        {
            var data = _unitOfWork.kullaniciRepository.Get(id);
            if (data != null)
            {
                var kullanici = _mapper.Map<Kullanici, KullaniciVM>(data);
                return new Result<KullaniciVM>(true, ResultConstant.RecordFound, kullanici);
            }
            else
            {
                return new Result<KullaniciVM>(false, ResultConstant.RecordNotFound);
            }
        }

        public Result<KullaniciVM> GetAllKullanici(string id)
        {
            var data = _unitOfWork.kullaniciRepository.Get(id);
            if (data != null)
            {
                var kullanici = _mapper.Map<Kullanici, KullaniciVM>(data);
                return new Result<KullaniciVM>(true, ResultConstant.RecordFound, kullanici);
            }
            else
            {
                return new Result<KullaniciVM>(false, ResultConstant.RecordNotFound);
            }
        }

        public Result<KullaniciVM> KullaniciGuncelle(KullaniciVM model)
        {
            if (model != null)
            {
                try
                {
                    var kullanici = _mapper.Map<KullaniciVM, Kullanici>(model);
                    _unitOfWork.kullaniciRepository.Update(kullanici);
                    _unitOfWork.Save();
                    return new Result<KullaniciVM>(true, ResultConstant.RecordCreateSuccess);
                }
                catch (Exception ex)
                {

                    return new Result<KullaniciVM>(false, ResultConstant.RecordCreateNotSuccess + " " + ex.Message.ToString());
                }
            }
            else
            {
                return new Result<KullaniciVM>(false, "Boş veri olamaz");
            }
        }

    }
}
