
int ZczytajLiczbe(string wiadomosc)
{
    int liczba = 0;
    bool isValid = false;

    while (!isValid)
    {
        Console.Write(wiadomosc);
        isValid = int.TryParse(Console.ReadLine(), out liczba);
        isValid = (liczba > 0);
        if (!isValid)
        {
            Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę naturalną.");
        }
    }

    return liczba;
}

int[,] WypelnijTablice(int Size)
{
    int[,] tablica = new int[Size, Size];
    int liczba = 1;

    for (int i = 0; i < Size; i++)
    {
        if (i % 2 == 0) // wiersze parzyste
        {
            for (int j = 0; j < Size; j++)
            {
                tablica[i, j] = liczba;
                liczba++;
            }
        }
        else // wiersze nieparzyste
        {
            for (int j = Size-1; j >= 0; j--)
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
    int rows = tablica.GetLength(0);
    int columns = tablica.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(tablica[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] przygotujTabeleCwiczenie2(int Size)
{
    int[,] array = new int[Size, Size];
    int currentCol = 0;
    int currentRow = 0;
    int direction = 0; // 0 - prawo; 1 - dół; 2 - lewo; 3 - góra

    for (int currentNumber = 1; currentNumber <= Size * Size; currentNumber++)
    {
        array[currentRow, currentCol] = currentNumber;
        switch (direction)
        {
            case 0: //w prawo
                if (currentCol + 1 >= Size || array[currentRow, currentCol + 1] != 0)
                {
                    direction = 1;
                    currentRow++;
                }
                else
                {
                    currentCol++;
                }
                break;
            case 1: //w dół
                if (currentRow + 1 >= Size || array[currentRow + 1, currentCol] != 0)
                {
                    direction = 2;
                    currentCol--;
                }
                else
                {
                    currentRow++;
                }
                break;
            case 2:
                if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                {
                    direction = 3;
                    currentRow--;
                }
                else
                {
                    currentCol--;
                }
                break;
            case 3:
                if (array[currentRow - 1, currentCol] != 0)
                {
                    direction = 0;
                    currentCol++;
                }
                else
                {
                    currentRow--;
                }
                break;
            default:

                break;
        }
    }

    return array;
}



int Size = ZczytajLiczbe("Podaj wartosc: ");
int[,] tablica1 = WypelnijTablice(Size);
int[,] tablica2 = przygotujTabeleCwiczenie2(Size);

Console.WriteLine("\n");
WypiszTablice(tablica1);
Console.WriteLine("\n\n");
WypiszTablice(tablica2);
