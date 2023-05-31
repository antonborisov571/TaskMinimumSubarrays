using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMinimum;

public interface IDeque<T> where T : IComparable<T>
{
    bool IsEmpty { get; }
    T PopBack();
    T PopFront();
    void PushBack(T data);
    void PushFront(T data);

}
