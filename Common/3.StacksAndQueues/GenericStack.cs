
namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        GenericList<T> MyList=new GenericList<T>();   

        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return MyList.AsString();
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return MyList.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            MyList.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            MyList.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the last object of the list and return it

            //Si la pila no está vacía
            if (MyList.Count() > 0)
            {
                //Obtener el último valor
                int lastIndex = MyList.Count() - 1;
                
                T value = MyList.Get(lastIndex);
                MyList.Remove(lastIndex);
                
                return value;
            }
            
            return default(T);
        }
    }
}