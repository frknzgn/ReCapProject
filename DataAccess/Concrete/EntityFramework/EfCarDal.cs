using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapProjectDbContext reCapProjectDbContext = new ReCapProjectDbContext())
            {
                var addedEntity = reCapProjectDbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                reCapProjectDbContext.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProjectDbContext reCapProjectDbContext = new ReCapProjectDbContext())
            {
                var deletedEntity = reCapProjectDbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                reCapProjectDbContext.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProjectDbContext reCapProjectDbContext = new ReCapProjectDbContext())
            {
                return reCapProjectDbContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectDbContext reCapProjectDbContext = new ReCapProjectDbContext())
            {
                return filter == null
                    ? reCapProjectDbContext.Set<Car>().ToList()
                    : reCapProjectDbContext.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapProjectDbContext reCapProjectDbContext = new ReCapProjectDbContext())
            {
                var uptadedEntity = reCapProjectDbContext.Entry(entity);
                uptadedEntity.State = EntityState.Modified;
                reCapProjectDbContext.SaveChanges();
            }
        }
    }
}
