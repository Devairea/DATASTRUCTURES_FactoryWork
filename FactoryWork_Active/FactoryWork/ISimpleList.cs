using System;

namespace FactoryWork
{
    /// <summary>
    /// a simple list data structure
    /// </summary>
    public interface ISimpleList
    {
        int Size {  get;}                
        bool IsFull();
        bool IsEmpty();        
        void Add(int index, Object o);
        void Add(Object o);        
        bool Remove(Object o);        
        int IndexOf(Object o);        
        Object Get(int index);        
        Object Set(int index, Object o);

    }
}
