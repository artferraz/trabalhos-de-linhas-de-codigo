using System;
					
public class Program
{
	public static void Main()
	{
	//DECLARAÇÃO DE VARIAVEIS
		String Nome;
		String Sobrenome;
		int Idade;
		int Ano;
		
		// COLETA DE VARIAVEIS
		Console.WriteLine("Insira Seu Nome: ");
		Nome = Console.ReadLine();
		Console.WriteLine("Insira Seu Sobrenome: ");
	    Sobrenome = Console.ReadLine();
		Console.WriteLine("Insira Sua Idade: ");
		Idade = Convert.ToInt16(Console.ReadLine());
		
		//OPERAÇÕES
		Ano = 2026 - Idade;
		
		//EXIBIÇÃO E TRATAMENTO DE DADOS
		Console.WriteLine("Olá " + Nome + " " + Sobrenome);
		Console.WriteLine(" Sua Idade é: " + Idade);
		Console.WriteLine(" Caso você já tenha feito aniversário, seu ano de nascimento é: " + Ano);
	}
}