
string[] S = System.IO.File.ReadAllLines(@"C:\Users\uczen\Desktop\Mat20\przyklad.txt"); // Wczytanie pliku (Dokumentacja: learn.microsoft.com)

int[] L = new int[S.Length];
string[] N = new string[S.Length];

//int k = 0;
//string[] LINIA = new string[2];

//int k = 0;
//foreach (string item in S)
//{
//    LINIA = item.Split(" ");
//    L[k] = int.Parse(LINIA[0]);
//    N[k] = LINIA[1];
    
    //L[k] = int.Parse((item.Split(" "))[0]);
    //N[k] = (item.Split())[1];
    //k++;
//}
// L - to ma być tablica intów
// N - to ma być tablica stringów

bool czyPierwsza(int n)
{
    for (int i = 2; i < n; i++)
        if (n % i == 0)
            return false;
    return true;
}

for (int i = 0; i < L.Length; i++)
{
    if (L[i] > 4 && L[i] % 2 == 0)
    {
        for (int j = 3; j < L[i]; j++)
        {
            if (czyPierwsza(j) && czyPierwsza(L[i] - j))
            {
                Console.WriteLine($"{L[i]} {j} {L[i] - j}");
                break;
            }
        }
    }
}
