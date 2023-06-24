static int[,] WypelnijTablice()
{
    const int Size = 10;
    int[,] tablica = new int[Size, Size];
    int liczba = 1;

    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0) // wiersze parzyste
        {
            for (int j = 0; j < 10; j++)
            {
                tablica[i, j] = liczba;
                liczba++;
            }
        }
        else // wiersze nieparzyste
        {
            for (int j = 9; j >= 0; j--)
            {
                tablica[i, j] = liczba;
                liczba++;
            }
        }
    }

    return tablica;
}

static void WypiszTablice(int[,] tablica)
{
    int liczbaWierszy = tablica.GetLength(0);
    int liczbaKolumn = tablica.GetLength(1);

    for (int i = 0; i < liczbaWierszy; i++)
    {
        for (int j = 0; j < liczbaKolumn; j++)
        {
            Console.Write(tablica[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] tablica = WypelnijTablice();
WypiszTablice(tablica);

