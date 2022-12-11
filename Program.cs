Console.WriteLine("Informe o valor do saque : \n");


int valor = Convert.ToInt32(Console.ReadLine());

    if(valor <= 0)
    {
  
        Console.WriteLine("\nValor invalido, por favor digite outro valor\n");
    
    }
    else if (valor % 2 == 0)
    {
        decimal notasdadas;
        notasdadas = valor / 200;
        Console.WriteLine($"{notasdadas} nota(s) de R$ ${200:C}");

        valor = valor % 200;


        notasdadas = valor / 100;

        Console.WriteLine($"{notasdadas} nota(s) de R$ ${100:C}");

        valor = valor % 100;


        notasdadas = valor / 50;

        Console.WriteLine($"{notasdadas} nota(s) de R$ ${50:C}");

        valor = valor % 50;


        notasdadas = valor / 20;

        Console.WriteLine($"{notasdadas} nota(s) de R$ ${20:C}");

        valor = valor % 20;


        notasdadas = valor / 10;

        Console.WriteLine($"{notasdadas} nota(s) de R$ ${10:C}");

        valor = valor % 10;

        notasdadas = valor / 5;

        Console.WriteLine($"{notasdadas} nota(s) de R$ ${5:C}");

        valor = valor % 5;
    }

    else
    {
        
        Console.WriteLine("\nValor invalido, por favor digite outro valor\n");

    }
 Console.WriteLine("\nObrigado por sua preferência :)\n ");
 Console.WriteLine("\ndigite qualquer tecla para o encerramento");
 Console.ReadKey();