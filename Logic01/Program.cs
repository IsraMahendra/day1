

using System;

OperatorAritmatika();

Console.ReadKey();

static void OperatorAritmatika()
{
    int mangga, apel, hasil = 0;

    Console.WriteLine("--Operator aritmatika--");
    Console.Write("Masukkan mangga : ");
    mangga = int.Parse(Console.ReadLine());
    Console.Write("Masukkan apel : ");
    apel = int.Parse(Console.ReadLine());

    hasil = mangga + apel;

    Console.WriteLine($"hasil mangga + apel = { hasil}");
}

static void Konversi()
{
    Console.WriteLine("--Konversi--");


    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;

    string strMyInt = Convert.ToString(myInt); 
    string strMyInt2 = myInt.ToString();

    Console.WriteLine(strMyInt);
    Console.WriteLine(strMyInt2);
    Console.WriteLine(Convert.ToDouble(myInt));    //Convert int to double
    Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
    Console.WriteLine(Convert.ToString(myBool));   //Convert bool to string
}
