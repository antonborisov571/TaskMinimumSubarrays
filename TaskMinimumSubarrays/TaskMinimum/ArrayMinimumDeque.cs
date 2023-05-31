using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

/// <summary>
/// Реализация задачи через двухсторонюю очередь.
/// </summary>
/// <typeparam name="T"></typeparam>
public class ArrayMinimumDeque<T> where T : IComparable<T>
{
    private DequeM<T> deque = new DequeM<T>();

    /// <summary>
    /// Данный метод возращает все минимальные элементы в массиве на отрезках длины length.
    /// Выполняется за O(n). У каждого отрезка сложность O*(1), кроме первого.
    /// </summary>
    /// <param name="length"></param>
    /// <param name="arr"></param>
    /// <returns>
    /// Массив минимальных элементов.
    /// </returns>
    public T[] GetMinimum(int length, params T[] arr)
    {
        var list = new List<T>();
        for (int i = 0; i < length; i++)
        {
            deque.Dequeue(arr[i]);
        }
        list.Add(deque.Minimum());
        for (int i = length; i < arr.Count(); i++)
        {
            if (arr[i - length].Equals(deque.Minimum()))
            {
                deque.Enqueue();
            }
            deque.Dequeue(arr[i]);
            list.Add(deque.Minimum());
        }
        return list.ToArray();
    } 
}
