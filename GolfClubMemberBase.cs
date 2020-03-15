using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MW08
{
    class GolfClubMemberBase
    {
        //Base class GolfClubMember
        public string Name {get; set;}
        public int Age {get; set;}
        public DateTime Birthday {get; set;}
        public int ID {get; set;}
        public bool Vote {get; set;}

        public GolfClubMemberBase(string name, int age, DateTime bd)
        {
            Name = name;
            Age = age;
            Birthday = bd;
        }

        public virtual void emailAlert(string message)
        {
            //Default 
            Console.WriteLine("Default alert");
        }
      


    }
}
