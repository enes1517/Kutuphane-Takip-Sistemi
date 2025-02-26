using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ProductDalBook
    {
         public List<book>GetAll()
        {
            using (BookContext context =new BookContext())
            {
                return context.Books.ToList();

            }

        }
        public void add(book book)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }

        }
        public void update(book book)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void delete(book book)
        {
            using (BookContext context = new BookContext())
            {
                var entity = context.Entry(book);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }




    }
}
