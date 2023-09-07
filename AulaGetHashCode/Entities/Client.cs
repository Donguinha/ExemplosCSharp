using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AulaGetHashCode.Entities
{
    internal class Client
    {
        public string name { get; set; }
        public string email { get; set; }



        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                throw new ArgumentException("Object is not a client");
            }

            Client client1 = obj as Client;

            return email.Equals(client1.email);
        }

        public override int GetHashCode()
        {
            return email.GetHashCode();
        }
    }
}
