using System;

namespace Generics;

public class Box<T>
{
    private T? item;

    public void Add(T newItem)
    {
        item = newItem;
    }


    public T GetItem()
    {
        if (item == null)
        {
            throw new InvalidOperationException("Item is null");
        }
        return item;
    }
}
