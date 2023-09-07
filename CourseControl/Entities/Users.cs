using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseControl.Entities;

namespace CourseControl.Entities
{
    internal class Users
    {
        public int number { get; set; }

        public Users(int number)
        {
            this.number = number;
        }

        public void ViewNumber()
        {
            Console.WriteLine(number);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Users))
            {
                return false;
            }
            Users objUsers = (Users)obj;
            return number.Equals(objUsers.number);
        }

        public override int GetHashCode()
        {
            return number.GetHashCode();
        }



        //public int CompareTo(object obj)
        //{
        //    if (!(obj is Users))
        //    {
        //        throw new ArgumentException("Error, is not a User");
        //    }
        //    Users user = obj as Users;
        //    return number.CompareTo(user.number);
        //}

        public override string ToString()
        {
            return $"Student number: {number}";
        }
    }
}
