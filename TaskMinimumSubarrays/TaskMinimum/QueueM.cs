using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

/// <summary>
/// Очередь минимумов на двух стеках.
/// </summary>
/// <typeparam name="T"></typeparam>
public class QueueM<T> where T : IComparable<T>
{
    private StackM<T> stack1 = new StackM<T>();
    private StackM<T> stack2 = new StackM<T>();

    /// <summary>
    /// Добавление элемента в очередь.
    /// Выполняется за O(1).
    /// </summary>
    /// <param name="data"></param>
    public void Dequeue(T data)
    {
        stack1.Push(data);
    }

    /// <summary>
    /// Удаление элемента из очереди.
    /// Выполняется за O(n)
    /// </summary>
    /// <returns></returns>
    public T Enqueue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Pop();
        }
        return stack2.Pop();
    }

    /// <summary>
    /// Возращает минимальный элемент в очереди.
    /// Выполняется за O(1).
    /// </summary>
    /// <returns></returns>
    public T Minimum()
    {
        return stack1.Minimum().CompareTo(stack2.Minimum()) > 0 && stack2.Minimum().CompareTo(default) != 0
            ? stack2.Minimum() 
            : stack1.Minimum();
    }
}
