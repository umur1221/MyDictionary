using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Dictionary<B, O>
    {
        B[] id;
        B[] tempId;
        O[] name;
        O[] tempName;
        public Dictionary()
        {
            id = new B[0];
            name = new O[0];
        }
        public void Add(B key, O value)
        {
            tempId = id;
            tempName = name;

            id = new B[id.Length + 1];
            name = new O[name.Length + 1];
            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
                id[i] = tempId[i];
            }
            name[name.Length - 1] = value;
            id[id.Length - 1] = key;

            Console.WriteLine("ID: " + key + " İsim: " + value + " başarıyla eklendi.");
        }
    }
}
