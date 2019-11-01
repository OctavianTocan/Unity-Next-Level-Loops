using System;
using System.Collections.Generic;
using System.Linq;

namespace UnfinishedStudios
{
    public static class RLoops
    {
        /// <summary>
        /// Loops in reverse a certain "number" of times, and returns the index each time.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="action"></param>
        public static void Do(int number, Action<int> action)
        {
            //Reverse loop.
            for (var i = number - 1; i >= 0; i--)
                action.Invoke(i);
        }
        
        /// <summary>
        /// Loops in reverse trough an enumerable, returning the index each time.
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
        /// Loops in reverse trough an enumerable, returning a value each time.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Do<T>(IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null)
                return;
            
            var elements = enumerable as T[] ?? enumerable.ToArray();
            for (var i = elements.Count() - 1; i >= 0; i--)
                action.Invoke(elements[i]);
        }
        
        /// <summary>
        /// Loops in reverse trough an enumerable, returning a value, and the index each time.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static void Do<T>(IEnumerable<T> enumerable, Action<T, int> action)
        {
            if (enumerable == null)
                return;
            
            var elements = enumerable as T[] ?? enumerable.ToArray();
            for (var i = elements.Count() - 1; i >= 0; i--)
                action.Invoke(elements[i], i);
        }
    }
}