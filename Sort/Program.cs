using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void SelectionSort(int[] a)
        {
            int n = a.Length;
            for(int i=0; i < n; i++)
            {
                // Đi tìm phần tử nhỏ nhất thứ i để đưa về vị trí i
                int minIndex = i;
                for(int j = i; j < n; j++)
                {
                    if (a[minIndex] > a[j])
                        minIndex = j;
                }
                // Đã tìm được phần tử nhỏ nhất, hoán vị về vị trí i
                if(minIndex != i)
                {
                    int temp = a[minIndex];
                    a[minIndex] = a[i];
                    a[i] = temp;
                }
                
            }
        }

        static void PrintArray(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
        }

        static int[] ReadArray()
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                a[i] = int.Parse(s);
            }

            return a;
        }

        static void Main(string[] args)
        {
            int[] a = ReadArray();
            //PrintArray(a);

            SelectionSort(a);

            PrintArray(a);
        }
    }
}
