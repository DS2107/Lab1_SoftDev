using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Stru_IVT_7_V8
{
    public class ArrayProcessor
    {
        public int[] SortAndFilter(int[] a)
        {
            int[] MyArray = new int[a.Length];
            MyArray = a;
           MyArray = CreateNewArray(MyArray);
            return a;
        }

        public int[] SortArray(int[] a)
        {
            Array.Sort(a);
            return a;
        }

        public int[] CreateNewArray(int[] a)
        {
            SortArray(a);
            var TempList =  a.ToList();
            for (int i = 0; i < TempList.Count; i++)
            {
                int b = TempList[i];
                if(b<1000 )
                {
                    if(b < 10000)
                    {
                        TempList.Remove(b);
                        TempList = TempList;
                        i--;
                    }
                   
                } // if 
            }
           
            a = TempList.ToArray();

            return a;
        }

    }
}
