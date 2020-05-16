using System;
using AutoMapper;
using cryptinop_cpo.Models;
using cryptinopAPI.Models;

namespace cryptinopAPI.AutoMapperProfils
{
    public class CryptinopProfile :Profile
    {
        public CryptinopProfile()
        {
            CreateMap<CategorieActivite, Categorie>();
        }
    }
}
