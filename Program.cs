using System;
using System.Security.Cryptography.X509Certificates;

class Recursividade
{

    
 
    
    

    static void Main(string[] args)
    {  
      
          
       
        
    }


    
}

 //Teste usando recursividade: A elevado a B.
    
    static int expoente(int a,int b)
    {
        

        if(b==0)
        {
            return 1;
        }

        return a*expoente(a,b-1);

    }

    static void Main(string[] args)
    {  
        Console.Write($"Digite um numero base: ");
        int a=Convert.ToInt32(Console.ReadLine());

        Console.Write($"\nDigite um expoente para {a}: ");
        int b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\n 2 elevado à {b} é igual a {expoente(a,b)}");
        
    }


    /*Programa Recursivo somatoria
        
    
            //teste somatoria.
            
        static int somatoria(int a)
    { 
        
      if(a==1)
      /*Não consigo implemetar variaveis da função Main aqui.
      Pensei em utilizar dois parametros aqui mas não foi possivel.
      Inclusive tinha feito o inverso do que está escrito. eu estava somando.*/
      {

        return 1;//Esse return simboliza que a operação seguinte será realizada uma ultima vez. Eu poderia retornar 'a'.
      }
     

        return a+somatoria(a-1);
      

        
    }



    static void Main(string[] args)
    {  
        
       Console.WriteLine("Digite um numero.");
       int c=Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine($"A somatoria de {c} é {somatoria(c)}");
        
    }*/

        
/*Recursão usando fibonacci.

static int Fibonacci(int a)
    {
        if(a==0 || a==1)
        {
            return a;
        }
        
        
           return Fibonacci(a-1)+Fibonacci(a-2);
           //Por que ele repete o processo?R:Aparentemente ela reabastece o metodo fatorial porque ele retorna fatorial.
           //Dúvidas que eu tinha ao desenvolver o programa.Inclusive eu mesmo me respondia.

    }



    static void Main(string[] args)
    {  
        Console.Write("Digite um Número para testar Fibonacci: ");
        int Valor= Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine(Fibonacci(Valor));

        /*O que entendi até agora na recursividade é:
        Basicamente o programa realizará um Loop usando a função inteiro até chegar ao caso base e depois ele retorna refazendo as etapas só que com as respostas já obtidas.
        o caso base é aquele que está entre os If's.
        ex: 1,1,2,3,5; Ele começa no 5 e vai reduzindo até chegar ao 1 especificado no caso base.
        
        
        }*/
    
/*Teste de recursividade usando fatoração
     static int fatorial(int a)
    {
        if(a<=1)
        {
            a=1;
            return a;
        }
        
        
           return a*fatorial(a-1);//Por que ele repete o processo?Não existe nenhum laço aparente.

    }

    static void Main(string[] args)
    {   Console.Write("Digite um Número para fatoração: ");
        int Valor= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Resultado da fatoração de {Valor}!= "+fatorial(Valor));
    }
*/
