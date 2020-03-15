using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MW08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome to the Golf Club Membership App**");
            //List of members
            List<GolfClubMemberBase> list = new List<GolfClubMemberBase>();
            list.Add(new Member("Fred", 25, new DateTime(1995, 01, 01)));
            list.Add(new JuniorMember("Freda", 16, new DateTime(2004, 01, 01)));

            foreach(GolfClubMemberBase member in list)
            {

                if (member is Member)
                {
                    member.emailAlert("Member: Email message...");
                }
                if (member is JuniorMember)
                {
                    member.emailAlert("Junior Member: Email message...");
                }
            }
        }
    }
}
