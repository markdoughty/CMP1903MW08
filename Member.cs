using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MW08
{
    class Member : GolfClubMemberBase
    {
        //'Normal' member of Golf Club
        //Constructor
        public Member(string n, int a, DateTime b) : base(n, a, b){}

        public override void emailAlert(string message)
        {
            //Console.WriteLine($"Sending **{message}** to {Name}");
            Output.email("The golf course is open");
           
        }
    }
}
