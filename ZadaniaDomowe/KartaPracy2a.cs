//Zad.1
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if ((a + b) / 2 == 0) 
{
//    Console.WriteLine("Tak");
}
//else;
{
//    Console.WriteLine("Nie"); 
}

//Zad.2
//int a = int.Parse(Console.ReadLine());
//int g = int.Parse(Console.ReadLine());
//if ((a + g) / 2 > Math.Pow(a * g, 1 / 3)
{
//   Console.WriteLine("Tak");
}
//else;
{
//    Console.WriteLine("Nie");
}

//Zad.3
int k = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
if (k == l && k != m && l != m)
{
    Console.WriteLine("Równe są" + k + l);
}
else;
{
if (k != l && k == m && l != m) 
{
Console.WriteLine("Równe są" + k + m);
}
    else;
    {
        if (k != l && k != m && l == m) 
        {
            Console.WriteLine("Równe są" + l + m);
        }
        else;
        {
            if (k != l && k != m && l != m || k == l && k == m && l == m) 
            {
                Console.WriteLine("Wszystkie liczby są równe lub każda jest inna.");
            }
        }
    }
}

//Zad.4
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());
//if (a < b && a < c && a < d)
{
  //      Console.WriteLine("Najmniejszą z podanych liczb jest" + a);
}
//else;
{
  //  if (b < a && b < c && b < d) 
    {
    //    Console.WriteLine("Najmniejszą z podanych liczb jest" + b);
    }
    //else;
    {
      //  if (c < a && c < b && c < d) 
        {
        //    Console.WriteLine("Najmniejszą z podanych liczb jest" + c);
        }
        //else;
        {
          //  if (d < a && d < b && d < c) 
            {
            //    Console.WriteLine("Najmniejszą z podanych liczb jest" + d);
            }
        }
    }
}

//Zad.5
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//if (a + b > c && a + c > b && b + c > a ) 
{
//    Console.WriteLine("Z podanych boków można zbudować trójkąt.");
}
//else;
{
//   Console.WriteLine("Z podanych boków nie można zbudować trójkąt.");
}

//Zad.6

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//if (a < 90 && b < 90 && c < 90 && (a + b + c) == 180)
{
//    Console.WriteLine("Trójkąt o podanych kątach jest ostrokątny.");
}
//else;
{
//    if (a == 90 || b == 90 || c == 90 && (a + b + c) == 180) 
    {
//        Console.WriteLine("Trójkąt o podanych kątach jest prostrokątny.");
    }
//    else;
    {
        //if (a > 90 || b > 90 || c > 90 && (a + b + c) == 180) 
        {
           // Console.WriteLine("Trójkąt o podanych kątach jest rozwartokątny.");
        }
    
    }
}
