using System;
using System.Collections.Generic;
using System.Linq;

namespace UnfinishedStudios
{
    public static class Loops
    {
        /// <summary>
        /// Loops a certain "number" of times, and returns the index each time.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="action"></param>
        public static void Do(int number, Action<int> action)
        {
            //Loop.
            for (var i = 0; i < number; i++)
                action.Invoke(i);
        }
        
        /// <summary>
        /// Loops trough an enumerable, returning the index each time.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Do<T>(IEnumerable<T> enumerable, Action<int> action)
        {
            if (enumerable == null)
                return;
            
            Do(enumerable.Count(), action);
        }
        
        /// <summary>
        /// Loops trough an enumerable, returning a value each time.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Do<T>(IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null)
                return;
            
            //Loop.
            foreach (var element in enumerable)
                action.Invoke(element);
        }
        
        /// <summary>
        /// Loops trough a dictionary, returning the key and value each time.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="action"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        public static void Do<T1, T2>(Dictionary<T1, T2> dictionary, Action<T1, T2> action)
        {
            if (dictionary == null)
                return;
            
            //Loop.
            foreach (var value in dictionary)
                action.Invoke(value.Key, value.Value);
        }
        
        /// <summary>
        /// Loops trough an enumerable, returning the value and index each time.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Do<T>(IEnumerable<T> enumerable, Action<T, int> action)
        {
            if (enumerable == null)
                return;
            
            //Loop.
            var enumerable1 = enumerable as T[] ?? enumerable.ToArray();
            for (var i = 0; i < enumerable1.Count(); i++)
                action.Invoke(enumerable1[i], i);
        }
    }
}