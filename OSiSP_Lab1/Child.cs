using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSiSP_Lab1
{
    public class Child: Base<string>
    {
        public string id;
        public string GetID()
        {
            return id;
        }
    }
}
