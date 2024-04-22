using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksperymentSłownikowy
{
    class ZłyClass : IUstaw, IEquatable<ZłyClass>
    {
        public int Key { internal get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as DictKey);
        }

        public bool Equals(ZłyClass other)
        {
            return other != null &&
                   Key == other.Key;
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }

    struct ZłyStruct : IUstaw, IEquatable<ZłyStruct>
    {
        public int Key { internal get; set; }

        public bool Equals(ZłyStruct other)
        {
            return Key == other.Key;
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
