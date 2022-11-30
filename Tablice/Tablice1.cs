/*
Wygeneruj tablicę n losowych liczb:
Random r = new Random()
r.Next(pocz, kon)
1. Znajdź największą liczbę w tablicy
2. Znajdź najmniejszą liczbę w tablicy
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy
5. Podaj rozpiętość tablicy (różnica max - min)
6. Podaj sumę liczb w tablicy
7. Podaj średnią wartość liczb w tablicy
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy
*/


/*Wygenerowanie losowych liczb w tablicy*/
int n = 10;
int pocz = 1;
int kon = 20;

int[] T = new int[n];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    T[i] = r.Next(pocz, kon);
}

for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}

/*1.Znajdź największą liczbę w tablicy*/

/*int maks = T[0];
for (int i = 0; i < T.Length; i++)
{
    if (T[i]>maks)
    {
        maks = T[i];
    }
}
Console.WriteLine("Największa jest:" + maks);*/

/*2.Znajdź najmniejszą liczbę w tablicy*/

/*int min = T[0];
for (int i = 0; i < T.Length; i++)
{
    if (T[i] < min)
    {
        min = T[i];
    }
}
Console.WriteLine("Najmniejsza jest:" + min);*/

/*5.Podaj rozpiętość tablicy(różnica max - min)*/
/*int mks = T[0];
int mn = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i] > mks) mks = T[i];
    if (T[i] < mn) mn = T[i];
}
Console.Write("Rozpiętość tablicy = " + (mks - mn));*/

/*6.Podaj sumę liczb w tablicy*/
/*int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += T[i];
}
Console.WriteLine("Podaj sumę liczb w tablicy = " + suma);*/

/*7.Podaj średnią wartość liczb w tablicy*/
/*int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += T[i];
}
Console.WriteLine("Średnią wartością liczb w tablicy jest:" + (suma/n));*/

/*8.Których liczb jest więcej w tablicy: parzystych czy nieparzystych?*/
/*int l = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] % 2 == 0) l += 1;
}
if (n / 2 < l) Console.Write("Więcej jest parzystych");
else if (n / 2 == l) Console.Write("Liczb parzystych i nie parzystych jest tyle samo");
else Console.Write("WiEcej jest liczb nieparzystych");*/

/*9.Ile w tablicy jest liczb pierwszych?*/
/*int f = 0;
bool flaga = true;
for (int i = 2; i < n; i++)
{
    if (n % i == 0) flaga = false;
}
if (flaga == true) Console.Write("Liczba pierwsza ");
else Console.Write("Liczba nie pierwsza ");*/


/*10. Podaj v-ce max i v-ce min liczb tablicy*/
