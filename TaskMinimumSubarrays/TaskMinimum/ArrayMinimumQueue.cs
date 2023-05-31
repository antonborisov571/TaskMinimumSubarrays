using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

/// <summary>
/// Реализация задачи через очередь минимумов.
/// </summary>
/// <typeparam name="T"></typeparam>
public class ArrayMinimumQueue<T> where T : IComparable<T>
{
    private QueueM<T> queue = new QueueM<T>();

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
        List<T> list = new List<T>();
        for (int i = 0; i < length; i++)
        {
            queue.Dequeue(arr[i]);
        }
        list.Add(queue.Minimum());
        for (int i = length; i < arr.Count(); i++) 
        {
            queue.Enqueue();
            queue.Dequeue(arr[i]);
            list.Add(queue.Minimum());
        }
        return list.ToArray();
    }
}
