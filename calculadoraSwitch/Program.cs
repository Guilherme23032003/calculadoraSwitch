Console.Title = "CALCULADORA SIMPLES +,-,/,x.";

Console.WriteLine();

Console.WriteLine(@"
                    
      oooo       oo      oo       oooo    oo  oo  oo         oo     oooooo   oooooooo  oooooo      oo
     oooooo    oo  oo    oo      oooooo   oo  oo  oo       oo  oo   oo   oo  oo   ooo  oo  oo    oo  oo
     oo       oo    oo   00      oo       oo  oo  oo      oo    oo  oo    o  oo  o oo  oo   o   oo    oo
     oo       oo oo oo   00      oo       oo  oo  oo      oo oo oo  oo    o  oo o  oo  ooooo    oo oo oo
     oo       oo    oo   oo      oo       oo  oo  oo      oo    oo  oo    o  ooo   oo  oo oo    oo    oo
     oooooo   oo    oo   oooooo  oooooo   oooooo  oooooo  oo    oo  oo   oo  oo    00  oo  oo   oo    oo
      oooo    oo    oo   oooooo   oooo    oooooo  oooooo  oo    oo  oooooo   oooooooo  oo   oo  oo    oo   ");

Console.Write("\n\ndigite qual operação deja realizar\nmultiplicação, divisão, soma ou subtração : ");

string operacao = Console.ReadLine();
double soma, sub;
double mul, div;

Console.Write("informe o primeiro numero da operação : ");
double nmr1 = double.Parse(Console.ReadLine());
Console.Write("informe o segundo numero da operação : ");
double nmr2 = double.Parse(Console.ReadLine());

switch (operacao)
{
    case "soma":
        soma = nmr1 + nmr2;
        Console.WriteLine("\nresultado: " + soma);
        break;

    case "subtração":
         sub = nmr1 - nmr2;
        Console.WriteLine( "\nresultado: " + sub);
        break;

    case "divisão":
        if (nmr2 <=0)
        {
            Console.WriteLine("impossivel dividir por numeros negativos ou zero.");
        }
        else
        {
            div = nmr1 / nmr2;
            Console.WriteLine("\nresultado: " + div.ToString("F2"));
            
        }
        break;

    case "multiplicação":
        mul= nmr1 * nmr2;
        Console.WriteLine("\nrsultado: " + mul.ToString("F2"));
        break;
}
Console.ReadKey();


 





                        