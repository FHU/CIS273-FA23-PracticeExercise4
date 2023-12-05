using System;

namespace PracticeExercise4
{
	public class HashTableLinearProbing<K,V>: IHashTable<K,V>
	{
		private Bucket<K, V>[] buckets;
		private int initialCapacity = 16;

		public HashTableLinearProbing()
		{
			buckets = new Bucket<K, V>[initialCapacity];

			for(int i=0; i< initialCapacity; i++)
			{
				buckets[i] = new Bucket<K, V>();
			}
		}

        private int count;
        public int Count => count;

        public double LoadFactor => throw new NotImplementedException();

        public bool Add(K key, V value)
        {
            // get hash

            // find the bucket index for hash

            // while collision, go to the next bucket

            // add key, value, update count
            // OR update


            // return true if update, false if add
        }

        public bool ContainsKey(K key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsValue(V value)
        {
            throw new NotImplementedException();
        }

        public V Get(K key)
        {
            throw new NotImplementedException();
        }

        public List<K> GetKeys()
        {
            throw new NotImplementedException();
        }

        public List<V> GetValues()
        {
            throw new NotImplementedException();
        }

        public bool Remove(K key)
        {
            throw new NotImplementedException();
        }

        private int Hash(K key)
        {
            int hash = key.GetHashCode();

            return hash < 0 ? -hash : hash;
        }

    }
}

