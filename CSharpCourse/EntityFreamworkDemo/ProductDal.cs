﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {

            using (ETradeContext context = new ETradeContext())
            {
               return context.Products.ToList(); //Tabloya erişim sağlamak için bu kadar kod yazıyoruz
            }
        }
        public List<Product> GetByName(string key)
        {

            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)). ToList(); //Tabloya erişim sağlamak için bu kadar kod yazıyoruz
            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {

            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min &&p.UnitPrice <= max).ToList(); //Tabloya erişim sağlamak için bu kadar kod yazıyoruz
            }
        }
        public Product GetById(int id)
        {

            using (ETradeContext context = new ETradeContext())
            {
              var result= context.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;

                context.SaveChanges(); //Tabloya ekleme yapmak için bu kod yazılır
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;

                context.SaveChanges(); //Tabloya ekleme yapmak için bu kod yazılır
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;

                context.SaveChanges(); //Tabloya ekleme yapmak için bu kod yazılır
            }
        }
    }
}
