﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPair
{
    public class Pair<T, K>
    {
        private T _first;
        private K _second;

        public T First
        {
            get { return _first; }
        }

        public K Second
        {
            get { return _second; }
        }

        private Pair(T t, K k)
        {
            this._first = t;
            this._second = k;
        }

        public static Pair<T, K> Of(T t, K k)
        {
            return new Pair<T, K>(t, k);
        }

        public override int GetHashCode()
        {
            return (_first.ToString() + _second.ToString()).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Pair<T, K> currentPair = null;
            if (obj is Pair<T, K>)
            {
                currentPair = obj as Pair<T, K>;
                if (this.First.Equals(currentPair.First) && this.Second.Equals(currentPair.Second))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;

        }
    }
    
    public static class Pair
    {
        public static Pair<T1, T2> Of<T1, T2>(T1 first, T2 second)
        {
            return Pair<T1, T2>.Of(first, second);
        }
    }

}
