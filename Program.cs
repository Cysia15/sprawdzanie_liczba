class Klaskamj
{

    static void Main(string[] args)
    {
        int liczba1, liczba2;
        Console.WriteLine("podaj liczbe");
        bool czylok = int.TryParse(Console.ReadLine(), out liczba1);

        Console.WriteLine("podaj druga liczbe ");
        bool czyl2ok = int.TryParse(Console.ReadLine(),out liczba2);

        if (liczba1 > liczba2)
        {
            Console.WriteLine($"ziomek liczba  {liczba1} jest wieksza");
        }
        else if (liczba1 < liczba2)
        {
            Console.WriteLine($"ziomek liczba  {liczba2} jest wieksza");
        }
        else
        {
            Console.WriteLine($"ziomek liczba  {liczba1} jest rowna");
        }

    }
}