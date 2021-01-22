using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new MyDictionary<int, string>();
            users.Add(1,"Gizem");
            users.Add(2,"İrem");
            users.Add(3,"Abdullah");
            Console.WriteLine(users.keyCount);
            Console.WriteLine(users.valueCount);


        }

    }
    class  MyDictionary<Tkey,Tvalue>
    {
        Tkey[] aKeys;
        Tvalue[] aValues;

         Tkey[] _tempKeys;
         Tvalue[] _tempValues;

        public MyDictionary()
        {
            aKeys = new Tkey[0];
            aValues = new Tvalue[0];
        }

        public void Add(Tkey _itemKey,Tvalue _itemValue)
        {
            _tempKeys = aKeys;
            _tempValues = aValues;
            aKeys = new Tkey[aKeys.Length + 1];
            aValues = new Tvalue[aValues.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                aKeys[i] = _tempKeys[i];
            }

            aKeys[aKeys.Length - 1] = _itemKey;

            for (int i = 0; i < _tempValues.Length; i++)
            {
                aValues[i] = _tempValues[i];
            }

            aValues[aValues.Length - 1] = _itemValue;
        }

        public int keyCount
        {
            get { return aKeys.Length; }
        }
        public int valueCount
        {
            get { return aValues.Length; }
        }

    }
}
