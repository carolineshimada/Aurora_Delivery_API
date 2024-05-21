﻿using AuroraDelivery.Domain.Entities;
using AuroraDelivery.Domain.Interface;
using AuroraDelivery.Domain.Interface.Repository;
using AuroraDelivery.Domain.Interfaces.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraDelivery.Service.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public IEnumerable<T> Get()
        {
            return _baseRepository.Get();
        }

        public T GetById(int id)
        {
            return _baseRepository.GetById(id);
        }

        public void Add(T entity)
        {
            _baseRepository.Add(entity);
        }

        public void Update(T entity)
        {
            _baseRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }
    }
}
