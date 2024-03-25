Console.WriteLine("Quicksort");
// Random rnd = new Random();

int[] liste =  new int[] { 9, 2, 3, 8, 5, 4, 11, 22, 24, 22, 23, 0, -1 };


Quicksort.Quicksort.quicksort(ref liste, 0, liste.Length - 1);
foreach (int i in liste)
{
    Console.Write(i + " ");
}
Console.ReadKey();