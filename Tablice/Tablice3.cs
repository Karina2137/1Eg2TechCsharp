////Tablice

//int[] T= new int[3];  //Deklaracja

//T[0] = 4;
//T[1] = 8;
//T[2] = 9; //Definicja

////Deklaracja i definicja w jednym

//int[] D = new int[] { 5, 8, 12, 16 };

////Przechodzenie po tablicy - 2 pętle (for i foreach)

//for (int i = 0; i < D.Length; i++)
//{
//    Console.WriteLine(D[i] + " ");
//}
//Console.WriteLine("\n");

//foreach (var item in D) 
//{
//    Console.WriteLine(item + " ");
//}
//Console.WriteLine("\n");


//Tablice 2-wymiarowe

//int[,] M = new int[2, 3];
//M[0, 0] = 3;
//M[0, 1] = 5;
//M[0, 2] = 2;
//M[1, 0] = 7;
//M[1, 1] = 9;
//M[1, 2] = 10;

//int[,] N = new int[,] { { 2, 3, 4 }, { 7, 8, 9 }, { 13, 14, 15 }, { 21, 31, 41 } };

//for (int i = 0; i < N.Length; i++)
//{
//    Console.WriteLine(N[i/N.GetLength(1),i%N.GetLength(1)]+ " ");
//}
//Console.WriteLine("\n");

//foreach (var item in N)
//{
//    Console.WriteLine(item + " ");
//}
//Console.WriteLine("\n");

//for (int i = 0; i < N.GetLength(0); i++)
//{
//    for (int j = 0; j < N.GetLength(1); j++)
//    {
//        Console.Write(N[i, j]+"\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();


//Typ wyliczeniowy (enum) od enumeration - była tylko teoria


//ArrayList

//using System.Collections;

//ArrayList A = new ArrayList();
//A.Add(1);
//A.Add(7);
//A.Add(19);
//A.Remove(7);
//A.RemoveAt(1);

//foreach (int i in A)
//{
//    Console.WriteLine(i + " ");
//}
//for(int i=0; i < A.Count; i++)
//{
//  Console.Write(A[i] + " ")
//}
