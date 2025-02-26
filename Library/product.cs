using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class product
    {
        public int Id { get; set; }
        public decimal MemberNumber { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public decimal PhoneNumber { get; set; }

    }

    public class book
    {
        public int Id { get; set; }
        public decimal BookNumber { get; set; }
        public string Name { get; set; }
        public decimal PublicationYear { get; set; }

        public decimal ISBN { get; set; }

    }
    public class member


    {
        public int Id { get; set; }
        public int MemberNumber { get; set; }
        public int BookNumber { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public int RemainingDay { get; set; }




    }

}
