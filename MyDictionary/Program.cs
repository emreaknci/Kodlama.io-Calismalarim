using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> product = new MyDictionary<string, int>();
            product.Add("Telefon", 3499);
            product.Add("Laptop", 8499);
            product.Add("Smart TV", 7699);

            foreach (string item in product.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (int item in product.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
    class MyDictionary<TKey,TValue>
    {
        TKey[] _Tkey;
        TValue[] _Tvalue;
        public MyDictionary()
        {
            _Tkey = new TKey[0];
            _Tvalue = new TValue[0];
        }
        public void Add(TKey tKey,TValue tValue)
        {
            TKey[] tempArrayKey = _Tkey;
            TValue[] tempArrayValue = _Tvalue;
            _Tkey = new TKey[_Tkey.Length + 1];
            _Tvalue = new TValue[_Tvalue.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                _Tkey[i] = tempArrayKey[i]; 
                _Tvalue[i] = tempArrayValue[i];
            }
            _Tkey[_Tkey.Length - 1] = tKey;
            _Tvalue[_Tvalue.Length - 1] = tValue;
        }
        public TKey[] Keys
        {
            get { return _Tkey; }
        }

        public TValue[] Values
        {
            get { return _Tvalue; }
        }
    }
}
