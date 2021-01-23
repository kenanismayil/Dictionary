using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        K[] tempKeys;
        V[] tempValues;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key,V value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new K[keys.Length+1];
            values = new V[values.Length+1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        //Keys
        public K[] Keys
        {
            get { return keys; }
        }

        //Values
        public V[] Values
        {
            get { return values; }
        }

        //Count
        public int Count
        {
            get { return keys.Length; }

        }
    }
}
