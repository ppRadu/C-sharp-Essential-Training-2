using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class AwesomeSauce
    {
        public List<string> Sauces { get; set; }

        public AwesomeSauce()
        {
            Sauces = new List<string>();
        }

        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }
    }
}
