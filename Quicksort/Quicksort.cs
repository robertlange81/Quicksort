using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Quicksort
    {
        public static void quicksort(int[] liste, int links, int rechts)
        {
            if (links < rechts)
            {
                foreach (int i in liste)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                int teiler = teile(liste, links, rechts);
                quicksort(liste, links, teiler - 1);
                quicksort(liste, teiler + 1, rechts);
            }
        }

        public static int teile(int[] liste, int links, int rechts)
        {
            int i = links;
            int j = rechts - 1;
            int pivot = liste[rechts];


            while (i < j)
            {
                for (; i < j && liste[i] <= pivot; i++)
                {
                }

                for (; i < j && liste[j] > pivot; j--)
                {
                }

                if (liste[i] > liste[j])
                {
                    int tmp = liste[i];
                    liste[i] = liste[j];
                    liste[j] = tmp;
                }
            }
            if (liste[i] > pivot)
            {
                liste[rechts] = liste[i];
                liste[i] = pivot;
            } else {
                i = rechts;
            }
            return i;
        }
    }
}
