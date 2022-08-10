namespace generics
{
    //5 generic types T constraints:
    // where T : IComparable -- specific Interface
    // where T : Product -- specific class of any of its derived classes
    // where T : struct -- value type
    // where T : calss -- reference type
    // where T : new() -- object that have a default constructor


    public class Utilities<T>where T : IComparable
    {
        /// <summary>
        /// return the biggest number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        // this will not compile because we do not know the type of the T
        //public T Max<T>(T a,T b)
        //{
        //    return a > b ? a : b;
        //}

        // we can make T condtion in the class and remove it from the method
        //public T Max<T>(T a, T b)where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
