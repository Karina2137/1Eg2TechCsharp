//1.User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.

int NWD(int a, int b)
{
    while (a != b)
    {
        if (a > b) a-=b;
        if (b > a) b-=a;
    }
    return a;
}
int NWW(int a, int b)
{
    return a*b/NWD(a, b);
}
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());

//Brute Force

//for (int i = 1; i < 100; i++)
//{
//    for (int j = 1; j < 100; j++)
//    {
//        if (NWD(i,j) == x && NWW(i,j) == y)
//        {
//            Console.WriteLine(i + " " + j);
//        }
//    }
//}

//Iloczyn nwd+nww

//int iloczyn = x+y;
//for (int i = 1; i <= iloczyn; i++)
//{
//    if (iloczyn % i == 0 && NWD(i, iloczyn / i) == x &&  NWW(i, iloczyn / i) == y && i < iloczyn/i)
//    {
//        Console.WriteLine(i + " " + iloczyn/ i);
//    }
//}

//2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.

//string pier = Console.ReadLine();
//string drug = Console.ReadLine();

//string[] P = pier.Split("/");
//string[] D = drug.Split("/");

//int a = int.Parse(P[0]);
//int b = int.Parse(P[1]);
//int c = int.Parse(D[0]);
//int d = int.Parse(D[1]);

//int mianownik = NWW(b, d);
//int licz1 = mianownik * a/b;
//int licz2 = mianownik * c/d;

//if (licz1 + licz2 > mianownik)
//    Console.WriteLine("TAK");
//else
//    Console.WriteLine("NIE");

//3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.



//4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.

//char[] samogloski = { 'a', 'e', 'o', 'i', 'y', 'u' };
//string napis = Console.ReadLine();
//int ilosc = 0;
//for (int i = 0; i < napis.Length; i++)
//{
//    if (samogloski.Contains(napis[i])) 
//        ilosc++;
//    else
//        --ilosc;
//}
//if (ilosc > 0) Console.WriteLine("Więcej samogłosek");
//else Console.WriteLine("Więcej spółgłosek");

//5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.

//6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby.

//7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
//Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
//i lecąc z jednakową prędkością przybywają w tym samym czasie. 
//Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

//8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
//a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb,
//które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
//Napisz program, który pomaga w takich obliczeniach.

//9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody,
//zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład,
//jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
//będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4.Masz dane wszystkie liczby, które Halinka wypowiedziała 
//podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

//10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował
//przechadzających się ludzi.
//W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
//obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
//znaleźć sobie miejsce na ławce.
//Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
//Jaka jest minimalna, a jaka maksymalna wartość k?

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//int m = int.Parse(Console.ReadLine());

//int maks1 = 0, k;
//int min1 = (a + b + c + m);
//if (a > b && a > c) maks1 = a;
//if (b > c && b > a) maks1 = b;
//if (c > a && c > b) maks1 = c;
//k = maks1 + m;
//Console.WriteLine("MAKS wartość k = " + k);

//if (min1 % 3 != 0) min1 = (min1 / 3) + 1;
//if (min1 < maks1) Console.WriteLine("MIN wartość k = " + maks1);
//else Console.WriteLine("MIN wartość k = " + min1);
