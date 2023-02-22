//Zad.1
//Wygeneruj tablicę z 15 losowymi liczbami dwucyfrowymi nieparzystymi
////SPOSÓB 1
//Random r = new Random();
//int[] T = new int[15];
//int liczba;
//for (int i =0; i < T.Length; i++)
//{
//    liczba = r.Next(5, 50);
//    T[i] = 2 * liczba + 1;
//}
//foreach (var e in T)
//{
//    Console.Write(e + " ");
//}

////SPOSÓB 2

//int x = 1;
//int[] R = new int[15];
//while (x<15)
//{
//    liczba = r.Next(10, 100);
//    if(liczba%2==1)
//    {
//        R[x] = liczba;
//        x++;
//    }
//}
//foreach (var i in T)
//{
//    Console.WriteLine(i + " ");
//}
//Console.WriteLine();

//Zad.2
//Wygeneruj tablicę 20 dowolnych liczb dwucyfrowych i potem zaokrąglij każdą w górę do pełnej 10-tki

//Random r = new Random();
//int[] T = new int[15];
//for (int i = 0; i < T.Length; i++)
//{
//    T[i] = r.Next(10, 100);
//    Console.Write(T[i] + " ");
//    if (T[i] % 10 != 0) T[i] = (T[i] / 10) * 10 + 10;
//    Console.WriteLine(T[i]);
//}
