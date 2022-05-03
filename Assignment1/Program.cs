using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MemberCollection aCollection = new MemberCollection(7);

            Member a = new Member("Andrew", "Sheu");
            Member b = new Member("matt", "Sheu");  
            Member c = new Member("rek", "Sheu");
            Member d = new Member("Samuel", "Sheu");
            Member w = new Member("annie", "lu");


            aCollection.Add(a);
            aCollection.Add(b);
            aCollection.Add(c);
            aCollection.Add(d);
            aCollection.Add(w);

            Member t = new Member("djs", "Sheu");



            Console.WriteLine("Adding the member to the list" +
                "" +
                "");
            aCollection.Display();

            Console.WriteLine("" +
                "" +
                "");

            /*
            Console.WriteLine("Delete member area");
            Console.WriteLine("Delete member :" + t.FirstName );
            aCollection.Delete(t);

            Console.WriteLine("");

            aCollection.Display();

            Console.WriteLine("");

            Console.WriteLine("Searching member area");
            Console.WriteLine("searching member :" + w.FirstName);


            aCollection.Search(w);


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

            
             

            string aa = "123";

            Console.WriteLine(IMember.IsValidPin(aa));
            Console.WriteLine();

           */

        }



    }
}
