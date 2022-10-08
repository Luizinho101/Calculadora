// See https://aka.ms/new-console-template for more information

int verificador=0;

while(verificador!=1)
{
    
    Console.WriteLine("TECLE 1 PARA SAIR ");
    Console.WriteLine("TECLE 2 PARA SOMAR ");
    Console.WriteLine("TECLE 3 PARA SUBTRAIR ");
    Console.WriteLine("TECLE 4 PARA MULTIPLICAR ");
    Console.WriteLine("TECLE 5 PARA DIVIDIR ");
    
    verificador=int.Parse(Console.ReadLine());
    
}
Console.WriteLine("O PROGRAMA VAI SER ENCERRADO !!!");