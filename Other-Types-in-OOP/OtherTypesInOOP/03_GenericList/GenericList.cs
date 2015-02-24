using System;
using System.Collections;

public class GenericList<T> where T : IComparable<T>
{
    const int DefaultCapacity = 16;

    private T[] elements;
    private int capacity;

    public GenericList(int capacity = DefaultCapacity)
    {
        this.Capacity = capacity;
        this.Length = 0;
        elements = new T[capacity];
    }

    public int Capacity
    {
        get { return this.capacity; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The capacity of the must be greater than 0");
            }

            this.capacity = value;
        }
    }

    public int Length { get; private set; }

    public void Add(T element)
    {
        if (this.Length == capacity)
        {
            capacity *= 2;
            T[] newElements = new T[capacity];
            elements.CopyTo(newElements, 0);
            elements = newElements;
        }

        this.Length++;
        this.elements[this.Length-1] = element;
    }

    public void RemoveElementByIndex(int index)
    {
        if (index < 0 || index >= this.Length)
        {
            throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
        }

        T[] destination = new T[this.Length - 1];
        if (index > 0)
        {
            Array.Copy(this.elements, 0, destination, 0, index);
        }

        if (index < this.Length - 1)
        {
            Array.Copy(this.elements, index + 1, destination, index, this.Length - index - 1);
        }

        this.elements = destination;
        this.Length--;
    }

    public void InsertElementAtPosition(T element, int index)
    {
        if (index < 0 || index >= this.Length)
        {
            throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
        }
        
        T[] destination = new T[this.Length+1];
        if (index > 0)
        {
            Array.Copy(this.elements, 0, destination, 0, index);
        }

        destination[index] = element;
        
        if (index < this.Length)
        {
            Array.Copy(this.elements, index, destination, index+1, this.Length - index);
        }

        this.elements = destination;
        this.Length++;
    }

    public int FindElementIndex(T element) 
    {
        for (int i = 0; i < this.Length; i++)
        {
            if (this[i].CompareTo(element) == 0)
            {
                return i;
            }
        }

        return -1;
    }
    
    public Boolean Contains(T element)
    {
        if (this.FindElementIndex(element) == -1)
        {
            return false;
        }

        return true;
    }

    public GenericList<T> Clear()
    {
        return new GenericList<T>();
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = elements[index];
            return result;
        }
    }

    public T Min<T>()
    {
        T[] newArray = new T[this.Length];
        Array.Copy(this.elements, 0, newArray, 0, this.Length);
        Array.Sort(newArray);
        return newArray[0];
    }

    public T Max<T>()
    {
        T[] newArray = new T[this.Length];
        Array.Copy(this.elements, 0, newArray, 0, this.Length);
        Array.Sort(newArray);
        return newArray[this.Length-1];
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < this.Length; i++)
        {
           result =  result + elements[i] + " "; 
        }

        return result;
    }
}
