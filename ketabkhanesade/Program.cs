using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketabkhanesade
{public class Book
    {


      /// peroperti/////
       
      
private string Title
        {
            get;
            set;
        }
        private string Author
        {
            get;
            set;
        }
        private string Isbn
        {
            get;
            set;
        }
        private int YrearOfPblication
        {
            get;
            set;
        }

        ////////constractor////
        public Book(string Title,string Author,string Isbn,int YrearOfPblication)
        {
            this.Title = Title;
            this.Author = Author;
            this.Isbn = Isbn;
            this.YrearOfPblication = YrearOfPblication;
        }
        //////metood//////
        public void print()
        {
            Console.WriteLine("title :"+Title);
            Console.WriteLine("authore :"+Author);
            Console.WriteLine("ISBN :"+Isbn);
            Console.WriteLine("year of pblication :"+YrearOfPblication);
        }

    }
    public class Member
    { 
             /////peroperti/////
        private string Name
        {
            get;
            set;
        }
        private string MemberId
        {
            get;
            set;
        }
        private int Phone
        {
            get;
            set;
        }

        ////////constractor////
        public Member(string Name,string MemberId,int Phone)
        {
            this.Name = Name;
            this.MemberId = MemberId;
            this.Phone = Phone;
        }
        ////metood///
        public void printmemberinfo()
        {
            Console.WriteLine("name :"+Name);
            Console.WriteLine("memberid :"+MemberId);
            Console.WriteLine("phone :"+Phone);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /////shay///
            Book myshay = new Book("boof kor","sadegh hedayt" ,"978_964-448_008_5", 1385);
            Book myshay1 = new Book("bi ketab","mohammd sharfi" ,"978_600_175_631_9", 1395);
            Member myshay2 = new Member("fati", "fati84", 099100000);
            Console.WriteLine("-------------ketabha--------------------");

            //////farakhani/////
            myshay.print();
            Console.WriteLine("----------------------------------------");
            myshay1.print();
            Console.WriteLine("======afrad======");
            myshay2.printmemberinfo();




            Console.ReadKey();
        }

        }
    }
