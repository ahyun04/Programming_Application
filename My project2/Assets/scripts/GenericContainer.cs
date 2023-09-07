using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>
{
    private T[] items;
    private int currentlndex = 0;

    public GenericContainer (int capacity)
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if(currentlndex < items.Length)
        {
            items[currentlndex] = item;
            currentlndex++;
        }
    }

    public T[] GetItems()
    {
        return items;
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
