using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class Booklist
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    ///// <summary>
    ///// performance penalty becuase of we do not know the the type
    ///// so boxing and unboxing always in place. 
    ///// </summary>
    //public class Objectlist
    //{
    //    public void Add(object book)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public object this[int index]
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotFiniteNumberException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}
