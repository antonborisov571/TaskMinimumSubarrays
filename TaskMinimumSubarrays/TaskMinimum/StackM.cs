using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

/// <summary>
/// Стек минимумов.
/// </summary>
/// <typeparam name="T"></typeparam>
public class StackM<T> : IStackM<T> where T : IComparable<T>
{
    /// <summary>
    /// Проверка на пустоту.
    /// </summary>
    public bool IsEmpty => Count == 0;

    /// <summary>
    /// Последний элемент в стеке.
    /// </summary>
    public NodeStack<T>? Head;
    /// <summary>
    /// Количество элементов в стеке.
    /// </summary>
    public int Count;

    /// <summary>
    /// Возращает последний элемент.
    /// Выполняется за O(1).
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException();
        }
        else
        {
            return Head!.Data;
        }
    }

    /// <summary>
    /// Удаляет последний элемент.
    /// Выполняется за O(1).
    /// </summary>
    /// <returns>
    /// Возращает последний элемент.
    /// </returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException();
        }
        else
        {
            var temp = Head;
            Head = Head!.Prev;
            Count--;
            return temp!.Data;
        }
    }

    /// <summary>
    /// Добавляет элемент в стек.
    /// Выполняется за O(1).
    /// </summary>
    /// <param name="data"></param>
    public void Push(T data)
    {
        var node = new NodeStack<T>(data);
        if (IsEmpty)
        {
            Head = node;
            Head.Minimum = data;
        }
        else
        {
            node.Prev = Head!;
            Head = node;
            Head.Minimum = data.CompareTo(Head.Prev.Minimum) < 0 ? data : Head.Prev.Minimum;
        }
        Count++;
    }

    /// <summary>
    /// Возращает минимальный элемент в стеке.
    /// Выполняется за O(1).
    /// </summary>
    /// <returns></returns>
    public T Minimum()
    {
        if (IsEmpty)
        {
            return default;
        }
        else
        {
            return Head!.Minimum;
        }
    }
}
