using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ProductDalMember
    {
        public List<member> GetAll()
        {
            using (MemberContext context = new MemberContext())
            {
                return context.Members.ToList();

            }

        }
        public void add(member member)
        {
            using (MemberContext context = new MemberContext())
            {
                var entity = context.Entry(member);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void update(member member)
        {
            using (MemberContext context = new MemberContext())
            {
                var entity = context.Entry(member);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }



        public void delete(member member)
        {
            using (MemberContext context = new MemberContext())
            {
                var entity = context.Entry(member);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

    }
}
