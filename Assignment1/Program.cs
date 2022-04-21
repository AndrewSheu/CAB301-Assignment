using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberCollection sCollection = new MemberCollection();

            //testing add

            Member f = new Member("Andrew", "Sheu");
            sCollection.Add(f);

            Member t = new Member("Andrew", "Sheu");
            sCollection.Add(t);

            Member y = new Member("Andrew", "Sheu");
            sCollection.Add(y);

            //sCollection.Delete();//"Sam","Sheu","0919340267" 
            //sCollection.Search(member);//"Sam","Sheu","0919340267"
            Console.WriteLine("Display Area");

            Console.WriteLine();

            sCollection.ToString();




            //testing delete
            //sCollection.Delete("Annie","Lu","0432291538");



            //testing search


        }
    }
}
