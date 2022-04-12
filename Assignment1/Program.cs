using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberCollection sCollection = new MemberCollection();

            //testing add
            sCollection.Add("Andrew","Sheu","0452276278");
            Console.WriteLine();


            //testing delete
            sCollection.Delete("Annie","Lu","0432291538");



            //testing search
            sCollection.Search("Sam","Sheu","0919340267");


            Console.WriteLine();


        }
    }
}
