using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MemberCollection aCollection = new MemberCollection(5);

            Member a = new Member("Andrew", "Sheu");
            Member b = new Member("matt", "Sheu");  
            Member c = new Member("rek", "Sheu");
            Member d = new Member("Andrew", "Sheu");


            aCollection.Add(a);
            aCollection.Add(b);
            aCollection.Add(c);

            Console.WriteLine("add section");
            Console.WriteLine();


            aCollection.Display();
            Console.WriteLine();

            //aCollection.Delete(c);
            //aCollection.Add(d);

            Console.WriteLine("delete section");
            Console.WriteLine();
                

            aCollection.Display();
            Console.WriteLine();


            Console.WriteLine("search section");
            aCollection.Search(a);

            Console.WriteLine();

            *//*

            string ab = "1234567897";
            string ac = "0234567897";



            Console.WriteLine(IMember.IsValidContactNumber(ab));
            Console.WriteLine();
            Console.WriteLine(IMember.IsValidContactNumber(ac));

            
             */

            string aa = "123";

            Console.WriteLine(IMember.IsValidPin(aa));
            Console.WriteLine();

           

        }



    }
}
