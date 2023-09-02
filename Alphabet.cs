using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class ABC
    {
        private List<string> alphabet = new List<string>();

        public ABC(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                alphabet.Add(arr[i]);
            }
        }

        public void OutPut()
        {
            foreach (string s in alphabet)
            {
                Console.Write(s + " ");
            }
        }
    }
}
