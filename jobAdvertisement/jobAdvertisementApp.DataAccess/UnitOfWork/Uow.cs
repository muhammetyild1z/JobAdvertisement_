﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jobAdvertisementApp.DataAccess.Contexts;
using jobAdvertisementApp.DataAccess.Interfaces;
using jobAdvertisementApp.DataAccess.Repositories;
using jobAdvertisementApp.Entities;

namespace jobAdvertisementApp.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AdvertisementContext _context;

        public Uow(AdvertisementContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
