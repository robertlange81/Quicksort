Console.WriteLine("Quicksort");
// Random rnd = new Random();

int[] unsortierteListe =  new int[] { 9, 2, 3, 8, 5, 4, 11, 22, 24, 22, 23, 0, -1 };


Quicksort.Quicksort.quicksort(unsortierteListe, 0, unsortierteListe.Length - 1);
Console.ReadKey();