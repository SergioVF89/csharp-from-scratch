//string nameInput=string.Empty;
Console.WriteLine("Ingrese un Numero: ");
int numberInput = Convert.ToInt32(Console.ReadLine());

if(numberInput > 0)
{
    Console.WriteLine($"El numero {numberInput} es positivo");
}
else if(numberInput < 0)
{
    Console.WriteLine($"El numero {numberInput} es negativo");
}
else
{
    Console.WriteLine($"El numero {numberInput} es cero");
}

//minuto 9 del video 11 https://www.youtube.com/watch?v=rar9qctS3wo