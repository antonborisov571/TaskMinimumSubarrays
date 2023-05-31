using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

public class NodeStack<T> where T : IComparable<T>
{
    /// <summary>
    /// Данные.
    /// </summary>
    public T Data { get; set; }
    /// <summary>
    /// Минимальные элемент во всём стеке.
    /// </summary>
    public T Minimum { get; set; }
    /// <summary>
    /// Предыдущий элеменет
    /// </summary>
    public NodeStack<T> Prev { get; set; }
    public NodeStack(T data)
    {
        Data = data;
    }
}
