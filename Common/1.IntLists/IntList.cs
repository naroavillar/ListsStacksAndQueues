using System;
using System.Collections.Generic;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            
            IntListNode newValue = new IntListNode(value);
            if (First == null)
            {
                First = newValue;
            }
            else
            {
                IntListNode valueList = First;
                while (valueList.Next != null)
                {
                    valueList = valueList.Next;
                }
                valueList.Next = newValue;
            }

        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            if (index < 0)
            {
                return null;
            }

            IntListNode value = First;
            int valueIndex = 0;

            while (value != null)
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

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            IntListNode node=GetNode(index);
            if (node == null)
            {
                return 0;
            }
            return node.Value;
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            int count = 0;
            IntListNode node = First;
            while (node != null)
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

            if (index == 0)
            {
                if (First!=null)
                {
                    First = First.Next;           
                }
              return;
            }

            IntListNode node = GetNode(index-1);
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
}