using FreshFruit.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFruit.model
{
    class Seller
    {
        private string name;
        private BucketController bucketController;

        public Seller (string name, BucketController bucketController)
        {
            this.name = name;
            this.bucketController = bucketController;
        }

        public List<Fruit> findAll ()
        {
            return this.bucketController.findAll();
        }

        public void addFruit (Fruit fruit)
        {
            this.bucketController.addFruit(fruit);
        }
    }
}
