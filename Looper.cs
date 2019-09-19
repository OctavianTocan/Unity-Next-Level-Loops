using System;
using System.Collections.Generic;

namespace UnfinishedStudios
{
    public static class Looper
    {
        public static void loop(int number, Action<int> action)
        {
            //Loop.
            for (var i = 0; i < number; i++)
                action.Invoke(i);
        }

        public static void loop<T>(List<T> list, Action<int> action)
        {
            //Loop with count.
            loop(list.Count, action);
        }

        public static void loop<T>(IReadOnlyList<T> list, Action<T> action)
        {
            //Loop.
            foreach (var t in list)
                action.Invoke(t);
        }

        public static void loop<T>(List<T> list, Action<T> action)
        {
            //Loop.
            foreach (var t in list)
                action.Invoke(t);
        }

        public static void rloop(int number, Action<int> action)
        {
            //Reverse loop.
            for (var i = number - 1; i >= 0; i--)
                action.Invoke(i);
        }

        public static void rloop<T>(List<T> list, Action<T> action)
        {
            //Reverse loop.
            for (var i = list.Count - 1; i >= 0; i--)
                action.Invoke(list[i]);
        }

        public static void rloop<T>(IReadOnlyList<T> list, Action<T> action)
        {
            //Reverse loop.
            for (var i = list.Count - 1; i >= 0; i--)
                action.Invoke(list[i]);
        }
        
        public static void rloop<T>(List<T> list, Action<int> action) { rloop(list.Count, action);}
    }
}