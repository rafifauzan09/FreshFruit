using FreshFruit.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFruit.controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener bucketEventListener;

        public BucketController (Bucket bucket, BucketEventListener bucketEventListener)
        {
            this.bucket = bucket;
            this.bucketEventListener = bucketEventListener;
        }

        public void addFruit (Fruit fruit)
        {
            if (isBucketOverload())
            {
                bucketEventListener.onFailed("opps keranjang sudah penuh gan!");
            } else
            {
                this.bucket.insert(fruit);
                bucketEventListener.onSucceed("yeeayy buah berhasil ditambahkan!");
            }
        }

        public bool isBucketOverload ()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }

        public void removeFruit (Fruit fruit)
        {
            for (int itemPos = 0; itemPos < bucket.countItems(); itemPos++)
            {
                if (bucket.findAll ().ElementAt(itemPos).getName() == fruit.name)
                {
                    bucket.remove(itemPos);
                    bucketEventListener.onSucceed("yeayyy berhasil dihapus");
                }
            }
        }

        public List<Fruit> findAll ()
        {
            return this.bucket.findAll();
        }
    }
}
