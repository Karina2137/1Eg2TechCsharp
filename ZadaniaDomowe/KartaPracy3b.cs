//Zad.1
/*
for (int i = 1; i < 31; i++)
{
    Console.Write(i + " ");
}

//Zad.2
for (int i = 0; i < 10; i++)
{
    if (i%2!=0)
    {
        Console.Write(i * i +" ");
    }
}

//Zad.3
for (int i = 999; i < 10000; i++)
{
    if (i%379==0)
    {
        Console.Write(i + " ");
    }
}

//Zad.4
for (int i = 100; i < 1000; i++)
{
    if (i%5==0 || i%6==0 || i%11==0)
    {
        Console.Write(i + " ");
    }
}

//Zad.5
int a = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0
    ; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());
    suma += b;
}
Console.Write(suma);

//Zad.6
int c = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 2; i < (c*2)+1; i+=2)
{
    suma += i;
}
Console.WriteLine(suma);

//Zad.7
int d = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 11; i < (d * 2)+11; i += 2)
{
    suma += i;
}
Console.WriteLine(suma);

//Zad.8
int e = int.Parse(Console.ReadLine());
int f= int.Parse(Console.ReadLine());
double suma = f;

for (int i = 0; i < f * 12; i++)
{
    g = suma * 0.06 * 1 / 12f;
    suma = suma + g;
}
Console.WriteLine(Math.Round(suma));

//Zad.9
int h = int.Parse(Console.ReadLine());
int k = 21;
int suma = 0;
for (int i = 0; i <= h; i++)
{
    for (int j = 0; j < i; j += k)
    {
        Console.WriteLine(k);
        suma += k;
        k += 100;
    }
}
Console.WriteLine(suma);

//Zad.10
int l = int.Parse(Console.ReadLine());
for (int i = 1; i < 1000; i++)
{
    if(i%10==Math.Sqrt(i) || i%100==Math.Sqrt(i))
    {
        Console.WriteLine(i);
    }
}*/