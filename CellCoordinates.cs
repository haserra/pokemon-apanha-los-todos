
namespace ConquerPokemonWorld
{
    /// <summary>   
    /// Cell Coordinates class.   
    /// </summary>         
    public class CellCoordinates
    {
        public int x { get; set; }
        public int y { get; set; }

        public CellCoordinates(int x, int y)
        {
           this.x = x;
           this.y = y;
        }

        public CellCoordinates()
        {
        }
    }
}
