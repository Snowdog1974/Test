using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class test : itest
    {
        public string print()
        {
            return "test1";
        }

    }


    class test2 : itest 
    {
        public string print()
        {
            return "test2";
        }
    }


    class test3 : itest
    {
        public string print()
        {
            return "test3";
        }
    }

    interface itest
    {
        string print();
    
    }
}
