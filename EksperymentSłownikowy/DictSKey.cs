using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksperymentSłownikowy
{
    struct DictSKey : IUstaw, IEquatable<DictSKey>
    {
        public int Key { internal get; set; }

        public bool Equals(DictSKey other)
        {
            return Key == other.Key;
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
