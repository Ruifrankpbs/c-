using System;
					
public class Program
{ 	
	public static void Main()
	{	 string Jogador;
	     string Arma;
		 string Porta;
		 string Monstro;
		
		 
	 	 
	 
	 	Console.WriteLine("Qual seu nome Jogador?");
	 	Jogador = Console.ReadLine();
	 Console.Clear();
		Console.WriteLine("Qual Arma voce escolhe:\n1-Facão\n2-38\n3-Pedaço de pau");
	 	Arma = Console.ReadLine();
	 	
			if (Arma == "1")
		{
			Arma = "Facão";
		}
		else if (Arma == "2")
		{
			Arma = "38";
		}
		else if (Arma == "3")
		{
			Arma = "Pedaço de pau";
		}
		else
		{
			Console.WriteLine("Sinto muito mas vc digitou um informação não válida\nPor isso vc terá que lutar sem Arma");
		}
	 Console.Clear();
	 	Console.WriteLine("Carregando"); 
	 	Console.WriteLine("==================###########====##=======##====##============================================================");
	    Console.WriteLine("==================###########====##=======##====##============================================================");
	    Console.WriteLine("==================##=======##====##=======##====##============================================================");
	    Console.WriteLine("==================###########====##=======##====##============================================================");
	    Console.WriteLine("==================###########====##=======##====##============================================================");
	    Console.WriteLine("==================##====##=======##=======##====##============================================================");
	    Console.WriteLine("==================##=====##======###########====##============================================================");
	    Console.WriteLine("==================##=====##======###########====##============================================================");
	    Console.WriteLine("Concluído"); 
	 
	 	Console.WriteLine("Temos 3 Portas, cada porta tem um tipo de Monstro...\nEscolha uma digitando 1,2 ou3");
	 	
	 	Porta = Console.ReadLine();
	 
	 	if (Porta == "1")
		{
			Monstro = "Onça";
		}
		else if (Porta == "2")
		{
			Monstro = "Hulk";
		}
		else if (Porta == "3")
		{
			Monstro = "Thanos";
		}
		else
		{	Monstro = "Devorador de Mundos";
			Console.WriteLine("Sinto muito mas vc digitou um informação inválida\nPor isso vc terá que lutar com o Monstro mais poderoso: " + Monstro);
			
		}
	 
	 	Console.WriteLine("Prepare-se!");
	 	Console.WriteLine( Monstro + " Está se preparando para atacar!");
	 	
	    Console.WriteLine( Monstro + " Ele está bem na sua frente!");
	 	Console.WriteLine("Aperte 1 para atacar com o "+ Arma);
	 	Console.ReadLine();
	 
	 
	 
	 	Ataque1(Jogador,Arma);
	 
	 
	 
	}
	
	 
	 
	
	public static void Ataque1(string nomeJogador, string nomeArma)
	{	 
	 		
			
			Console.WriteLine("Jogador "+ nomeJogador + " Atacou com  " + nomeArma);
			
		
	 		 	
	}
}