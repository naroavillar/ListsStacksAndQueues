using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        GenericListNode <T> newValue= new GenericListNode <T> (value);
        
        //si no hay valor
        if (First == null)
        {
            First = newValue;
        }
        //si hay valor
        else
        {
            GenericListNode<T> valueList = First;
            while (valueList.Next != null)//después hay otro valor
            {
                valueList = valueList.Next;
            }
            valueList.Next = newValue; //es el último
        }

    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        
        if (index < 0)
        {
            return null;
        }

        GenericListNode<T> value = First;
        int valueIndex = 0;

        while (value != null) //si hay valor 
        {
            if (valueIndex == index)
            {
                return value;
            }

            value = value.Next;
            valueIndex++;

        }
        return null;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        GenericListNode<T> node = FindNode(index);
        if (node == null)
        {
            return default(T);
        }

        return node.Value;
        
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list
        int count = 0;
        GenericListNode<T> node = First;
        while (node != null) //si hay valor
        {
            count++;
            node = node.Next;
        }
        return count;

    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds

        if (index < 0)
        {
            return;
        }

        if (index == 0) //el primer elemento
        {
            if (First != null)
            {
                First = First.Next;
            }
            return;
        }

        GenericListNode<T> node = FindNode(index - 1);
        if (node == null || node.Next == null)
        {
            return;
        }
        node.Next = node.Next.Next;
    }

    public void Clear()
    {
        //TODO #6: remove all the elements on the list
        First = null;
    }
}