using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary.Entities
{
    internal class PersonVote 
    {
        public int vote { get; set; }

        public PersonVote() { }

        public PersonVote( int vote) 
            
        {
            this.vote = vote;
        }

    }
}
