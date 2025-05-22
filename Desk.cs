using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Fanfan
{
    internal class Desk
    {
        // the minimum and maximum width and depth of the desk
        public const int MAX_WIDTH = 96;
        public const int MAX_DEPTH = 48;
        public const int MIN_WIDTH = 24;
        public const int MIN_DEPTH = 12;
        public const int MAX_DRAWERS = 7;
        public const int MIN_DRAWERS = 0;
        // the desk object with width, depth, number of drawers, and the surface material.
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public string SurfaceMaterial { get; set; }
        public Desk(int width, int depth, int numberOfDrawers, string surfaceMaterial)
        {
            Width = width;
            Depth = depth;
            NumberOfDrawers = numberOfDrawers;
            SurfaceMaterial = surfaceMaterial;
        }
        // the constructor for the desk object with width, depth, number of drawers, and the surface material.
        public Desk(int width, int depth, int numberOfDrawers)
        {
            Width = width;
            Depth = depth;
            NumberOfDrawers = numberOfDrawers;
            SurfaceMaterial = string.Empty;
        }


    }
    
    
}
