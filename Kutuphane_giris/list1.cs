using System;
using System.Collections.Generic;
using Kutuphane_giris.Entity;

namespace Kutuphane_giris
{
    internal class list<T>
    {
        public static implicit operator list<T>(List<Kisi> v)
        {
            throw new NotImplementedException();
        }
    }
}