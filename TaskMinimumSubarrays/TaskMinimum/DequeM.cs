using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

/// <summary>
/// Очередь, в которой минимумом является первый узел.
/// </summary>
/// <typeparam name="T"></typeparam>
public class DequeM<T> where T : IComparable<T> 
{
    private Deque<T> _deque = new Deque<T>();

    /// <summary>
    /// Добавление элемента в очередь.
    /// Выполняется за O*(1).
    /// </summary>
    /// <param name="data"></param>
    public void Dequeue(T data)
    {
        var node = new NodeDeque<T>(data);
        while (!_deque.IsEmpty && data.CompareTo(_deque.Tail!.Data) < 0)
        {
            _deque.PopBack();
        }
        _deque.PushBack(data);
    }

    /// <summary>
    /// Удаление элемента из очереди.
    /// Выполняется за O(1).
    /// </summary>
    /// <returns></returns>
    public T Enqueue()
    {
        return _deque.PopFront();
    }

    /// <summary>
    /// Данный метод возращает первый элемент.
    /// Выполняется за O(1).
    /// </summary>
    /// <returns></returns>
    public T Minimum()
    {
        return _deque.Head != null ? _deque.Head.Data : default;
    }
}
