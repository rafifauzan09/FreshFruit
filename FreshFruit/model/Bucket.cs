using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFruit.model
{
    
    class Bucket
    {
        private int capacity;
        private List<Fruit> fruits;

        public Bucket (int capacity)
        {
            this.capacity = capacity;
            this.fruits = new List<Fruit>();
        }

        public void insert (Fruit fruit)
        {
            this.fruits.Add(fruit);
        }

        public void remove (int pos)
        {
            this.fruits.RemoveAt(pos);
        }

        public List<Fruit> findAll ()
        {
            return this.fruits;
        }

        public int getCapacity ()
        {
            return this.capacity;
        }

        public int countItems ()
        {
            return this.fruits.Count();
        }
    }
}
