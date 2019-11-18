using System.Collections.Generic;


namespace ConquerPokemonWorld
{
    /// <summary>   
    /// PokemonWorld class.   
    /// </summary>                        
    public class PokemonWorld
    {
        //Ash's defaults
        private int posX = 0;
        private int posY = 0;
        private int catchedUpPokemons = 0;

        CellCoordinates initialPosition = new CellCoordinates(0, 0);        
        // lista onde são guardadas todas as coordenadas do percurso realizado pelo Ash
        public List<CellCoordinates> ashPath = new List<CellCoordinates>();

        public int CatchedUpPokemons
        {
            get
            {
               return catchedUpPokemons;
            }                
        }

        public CellCoordinates this[int index]
        {
            get { return ashPath[index]; }
            set { ashPath[index] = value; }
        }

        public PokemonWorld()
        {            
            ashPath.Add(initialPosition);
            posX = 0;
            posY = 0;
            catchedUpPokemons = 1;
        }

        // Move (direction) 
        public void Move(char direction)
        {
            CellCoordinates newPosition = new CellCoordinates();
            CellCoordinates item = new CellCoordinates();
            switch (direction)
            {
                case 'N':                    
                    posY++;
                    item = ashPath.Find(_item => ((_item.x == posX) && (_item.y == posY)));
                    if (item != null)
                    {
                        // já passei por aqui. este já o tinha apanhado.                        
                    }
                    else
                    {
                        // apanhei mais um. 
                        catchedUpPokemons++;
                    }

                    // guardo na lista a posição onde estou agora. 
                    newPosition.x = posX;
                    newPosition.y = posY;
                    ashPath.Add(newPosition);
                    break;
                case 'S':                    
                    posY--;
                    item = ashPath.Find(_item => ((_item.x == posX) && (_item.y == posY)));
                    if (item != null)
                    {
                        //já passei por aqui. este já o tinha apanhado.
                    }
                    else
                    {
                        // apanhei mais um.
                        catchedUpPokemons++;
                    }

                    // guardo na lista a posição onde estou agora. 
                    newPosition.x = posX;
                    newPosition.y = posY;
                    ashPath.Add(newPosition);
                    break;
                case 'E':
                    posX++;
                    item = ashPath.Find(_item => ((_item.x == posX) && (_item.y == posY)));
                    if (item != null)
                    {
                        // já passei por aqui. este já o tinha apanhado.
                    }
                    else
                    {
                        // apanhei mais um.
                        catchedUpPokemons++;
                    }

                    // guardo na lista a posição onde estou agora. 
                    newPosition.x = posX;
                    newPosition.y = posY;
                    ashPath.Add(newPosition);                    
                    break;
                case 'O':                    
                    posX--;
                    item = ashPath.Find(_item => ((_item.x == posX) && (_item.y == posY)));

                    if (item != null)
                    {
                        // já passei por aqui. este já o tinha apanhado.
                    }
                    else
                    {
                        // apanhei mais um.
                        catchedUpPokemons++;
                    }

                    // guardo na lista a posição onde estou agora. 
                    newPosition.x = posX;
                    newPosition.y = posY;
                    ashPath.Add(newPosition);
                    break;
                default:
                    break;
            }
        }
    }
}
