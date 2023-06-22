string resposta;

bool 
temperatura = false,
pressao = false,
rpm = false;

﻿void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else if (fun == 03)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else if (fun == 04)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
    }
     else if (fun == 05)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
     else if (fun == 06)
    {
        Console.ForegroundColor = ConsoleColor.Black;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(45);
}
    }

Console.Clear();
Shin("Responda as perguntas a seguir com as palavras: Ativado ou Desativado\n\n",00);
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Pressione qualquer tecla para continuar. . .");
Console.ReadKey();

Console.Clear();

Shin("Sensor de temperatura está: ",03);
Console.ForegroundColor = ConsoleColor.White;
resposta = Console.ReadLine()!;

if (resposta.Trim().ToUpper().Substring(0,1) == "A")
{
    temperatura = true;
}

Shin("Sensor de Pressão está: ",04);
Console.ForegroundColor = ConsoleColor.White;
resposta = Console.ReadLine()!;

if (resposta.Trim().ToUpper().Substring(0,1) == "A")
{
    pressao = true;
}


Shin("Sensor de RPM está: ",01);
Console.ForegroundColor = ConsoleColor.White;
resposta = Console.ReadLine()!;

if (resposta.Trim().ToUpper().Substring(0,1) == "A")
{
    rpm = true;
}

if (temperatura == true && (pressao == true || rpm == false))
{
    Shin($"\nLuz de Advertencia Ligada!",05);
}
else
{
    Shin($"\nLuz de Advertencia Desligada. . .",06);
}
Console.ResetColor();
Thread.Sleep(1550);
Console.Clear();