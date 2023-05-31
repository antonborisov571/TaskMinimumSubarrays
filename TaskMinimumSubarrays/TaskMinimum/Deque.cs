using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

/// <summary>
/// Двухсторонняя очередь.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Deque<T> : IDeque<T> where T : IComparable<T>
{
    /// <summary>
    /// Первый элемент.
    /// </summary>
    public NodeDeque<T>? Head;
    
    /// <summary>
    /// Последний элемент.
    /// </summary>
    public NodeDeque<T>? Tail;

    /// <summary>
    /// Проверка на пустоту.
    /// </summary>
    public bool IsEmpty => Count == 0;
    /// <summary>
    /// Количество элементов в очереди.
    /// </summary>
    public int Count;

    /// <summary>
    /// Удаление последнего элемента.
    /// Данный метод выполняется за O(1).
    /// </summary>
    /// <returns>
    /// Последний элемент.
    /// </returns>
    public T PopBack()
    {
        if (IsEmpty)
        {
            return default;
        }
        else
        {
            var temp = Tail!.Data;
            Tail = Tail.Next;
            if (Tail != null) 
                Tail.Prev = null;
            Count--;
            return temp;
        }
    }

    /// <summary>
    /// Удаление первого элемента.
    /// Данный метод выполняется за O(1).
    /// </summary>
    /// <returns>
    /// Первый элемент.
    /// </returns>
    public T PopFront()
    {
        if (IsEmpty)
        {
            return default;
        }
        else
        {
            var temp = Head!.Data;
            Head = Head.Prev;
            if (Head != null) 
                Head.Next = null;
            Count--;
            return temp;
        }
    }

    /// <summary>
    /// Добавление элемент в конец очереди.
    /// Данный метод выполняется за O(1)
    /// </summary>
    /// <param name="data"></param>
    public void PushBack(T data)
    {
        var node = new NodeDeque<T>(data);
        if (IsEmpty)
        {
            Tail = node;
            Head = node;
        }
        else
        {
            Tail!.Prev = node;
            node.Next = Tail;
            Tail = node;
        }
        Count++;
    }

    /// <summary>
    /// Добавление элемента в начало очереди.
    /// Данный метод выполняется за O(1)
    /// </summary>
    /// <param name="data"></param>
    public void PushFront(T data)
    {
        var node = new NodeDeque<T>(data);
        if (IsEmpty)
        {
            Tail = node;
            Head = node;
        }
        else
        {
            Head!.Next = node;
            node.Prev = Head;
            Head = node;
        }
        Count++;
    }
}
