using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberCollection sCollection = new MemberCollection();

            //testing add
            sCollection.Add(member.firstname = "Andrew", member.lastname = "Sheu");//"Andrew","Sheu","0452276278"
            sCollection.Delete();//"Sam","Sheu","0919340267" 
            sCollection.Search();//"Sam","Sheu","0919340267"
            sCollection.ToString();
            Console.WriteLine();



            //testing delete
            //sCollection.Delete("Annie","Lu","0432291538");



            //testing search


            Console.WriteLine();


        }
    }
}
