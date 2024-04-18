using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core4
{
    public class List<T>
    {
        private static int _id;
        public int Id { get; }
        public int Count { get; set; }
        public int Capacity { get ; set; }

       public  T[] items;

        public List() 
        {
            Id = ++_id;
            Capacity = 4;//Chunki listlerin tutumu Arraylardan ferqli olaraq 4 -den baslayir ve her defesinde 2 defe artir
            items= new T[Capacity];
            
        }

        public T this[int index]
        {
            get { return items[index]; }
        }


        public void Add(T item)
        {
  
                Capacity *= 2;
                Array.Resize(ref items, items.Length+1);
                items[items.Length-1] = item;
                Count++;
        }
        public void Find(Func<T, bool> func)
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (func(items[i]))
                {
                    Console.WriteLine(items[i]);
                    return;
                }
            }
        }
        public void FindAll (Func<T, bool> func)
        {
            for(int i = 0;i < Count; i++)
            {
                if (func(items[i]))
                {
                    Console.WriteLine(items[i]);
                }
            }

        }
       
           

        

    }
}
