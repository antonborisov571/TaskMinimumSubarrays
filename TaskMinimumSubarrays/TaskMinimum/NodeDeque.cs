using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

public class NodeDeque<T> where T : IComparable<T>
{
    /// <summary>
    /// Данные.
    /// </summary>
    public T Data { get; set; }
    /// <summary>
    /// Следующий узел.
    /// </summary>
    public NodeDeque<T>? Next { get; set; }
    /// <summary>
    /// Предыдущий узел.
    /// </summary>
    public NodeDeque<T>? Prev { get; set; }
    public NodeDeque(T data)
    {
        Data = data;
    }
}
