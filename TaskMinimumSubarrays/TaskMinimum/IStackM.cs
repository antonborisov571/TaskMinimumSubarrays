using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

public interface IStackM<T> where T : IComparable<T>
{
    T Pop();
    void Push(T data);
    T Peek();
    bool IsEmpty { get; }
    T Minimum();
}
