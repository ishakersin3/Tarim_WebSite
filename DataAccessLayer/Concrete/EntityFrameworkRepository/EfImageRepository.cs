﻿using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameworkRepository
{
    public class EfImageRepository:GenericRepository<Image>,IImageDAL
    {
    }
}
