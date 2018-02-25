using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class Sorter
    {
        public static int[] mergeSort(int[] x)
        {
            int length = x.Length;
            int[] left, right;

            if (length <= 1) return x;

            int middle = length / 2;
            left = new int[middle];
            right = new int[length - middle];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = x[i];
            }
            for (int i = middle; i < x.Length; i++)
            {
                right[i - middle] = x[i];
            }

            left = mergeSort(left);
            right = mergeSort(right);
            return merge(left, right);
        }

        public static int[] QuickSort(int[] x, int start, int end)
        {
            if (start < end)
            {
                int pIndex = partition(x, start, end);
                QuickSort(x, start, pIndex - 1);
                QuickSort(x, pIndex + 1, end);
            }

            return x;
        }

        private static int partition(int[] x, int start, int end)
        {
            int temp;
            int pivot = x[end];
            int i = start;
            for(int j = start; j < end; j++)
            {
                if(x[j] <= pivot)
                {
                    temp = x[j];
                    x[j] = x[i];
                    x[i] = temp;
                    i++;
                }
            }
            temp = x[i];
            x[i] = x[end];
            x[end] = temp;
            return i;
        }

        private static int[] merge(int[] l, int[] r)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int[] result = new int[l.Length + r.Length];
            while (i < l.Length || j < r.Length)
            {
                if (i < l.Length && j < r.Length)
                {
                    if (l[i] < r[j])
                    {
                        result[k++] = l[i++];
                    }
                    else
                    {
                        result[k++] = r[j++];
                    }
                }
                else if (i < l.Length)
                {
                    result[k++] = l[i++];
                }
                else if (j < r.Length)
                {
                    result[k++] = r[j++];
                }
            }
            return result;
        }
    }
}
