using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ProductDal
    {
        public List<product> GetAll()
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Products.ToList();
            }
        }
        public void add(product product)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                 context.SaveChanges();
            }

        }
        public void update(product product)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void delete(product product)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }



    }
}
