using System;
namespace PracticeExercise4
{
	public interface IHashTable<K, V>
	{
		/// <summary>
		/// Add key value pair or update value if key is already present.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns>Return true if the key was already present in hash table </returns>
		bool Add(K key, V value);

		V Get(K key);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <returns>Return true if the key was in the hash table</returns>
		bool Remove(K key);


		bool ContainsKey(K key);

		bool ContainsValue(V value);

		int Count { get; }

		List<K> GetKeys();

		List<V> GetValues();

		double LoadFactor { get; }
	}
}

