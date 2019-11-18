using System;


namespace ConquerPokemonWorld
{
    /// <summary>   
    /// Pokemon apanha-los todos. programa principal.   
    /// H.A.Serra 18/19 fevereiro 2017
    /// </summary>     
    class Program
    {
        static void Main(string[] args)
        {                      
            string ashMotionSequence = "NSEO";
            string directionsNotAllowed = "";
            string motionSequence = "";

            if (args.Length > 0)
            {
                // verifica se a sequência de movimentos é diretamente inserida a partir da linha de comandos 
                foreach (string str in args)
                {
                    motionSequence += str;
                }
            }
            else
            {
                Console.WriteLine("Indique a sequência de movimentos que o Ash deve realizar.\n");
                motionSequence = Console.ReadLine();
            }

            // verifica se há pelo menos um movimento para o Ash
            if (motionSequence.Length > 0)
            {
                foreach (char dir in motionSequence)
                {
                    if (ashMotionSequence.IndexOf(dir) == -1)
                    {                        
                        directionsNotAllowed += dir;
                    }
                }

                // verifica se as letras que descrevem os movimentos são sequências que contenham N, S, E ou O
                if (directionsNotAllowed == "")
                {
                    PokemonWorld conquerPokemons = new PokemonWorld();

                    foreach (char dir in motionSequence)
                    {
                        conquerPokemons.Move(dir);
                    }

                    Console.WriteLine($"\n{conquerPokemons.CatchedUpPokemons}");
                    Console.ReadKey();
                }
                else
                {                    
                    Console.WriteLine($"\nA sequência de movimentos introduzida, não está correcta.\nOs seguintes movimentos não são válidos: { directionsNotAllowed}.\n\nIndique sequências que contenham N, S, E ou O");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Não inseriu nenhuma sequência de movimentos.\nPrima uma tecla para sair.");
                Console.ReadKey();
            }
        }
    }
}
