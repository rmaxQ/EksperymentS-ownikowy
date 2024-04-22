using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksperymentSłownikowy
{
    class DictKey : IEquatable<DictKey> , IUstaw
    {
        public int Key { internal get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as DictKey);
        }

        public bool Equals(DictKey other)
        {
            return other != null &&
                   Key == other.Key;
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
