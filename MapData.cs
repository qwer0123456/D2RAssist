using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2RAssist
{
    class MapData
    {
        public XY levelOrigin;
        public Dictionary<string, AdjacentLevel> adjacentLevels;
        public int[][] mapRows;
        public Dictionary<string, XY[]> npcs;
        public Dictionary<string, XY[]> objects;
    }

    class XY
    {
        public int x;
        public int y;
    }

    class AdjacentLevel
    {
        public XY[] exits;
        public XY origin;
        public int width;
        public int height;
    }
}
