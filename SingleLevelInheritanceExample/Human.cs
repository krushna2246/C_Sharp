using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritanceExample
{
    public class Human:Barin
    {
        public string Gender="male";
        public string Legs()
        {
            return "1 human 2 Legs";
        }
        public string Hand()
        {
            return "1 human 2 hands";
        }
    }

    public class Barin
    {
        public string BarinFunction()
        {
            return "I can think";
        }
    }


}
