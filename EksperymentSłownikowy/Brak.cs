using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksperymentSłownikowy
{
    class BrakClass : IUstaw
    {
        public int Key { internal get; set; }
    }

    struct BrakStruct : IUstaw
    {
        public int Key { get; set; }
    }
}
