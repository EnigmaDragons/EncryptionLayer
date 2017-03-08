using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using MonoDragons.Core.Common;
using MonoDragons.Core.Engine;

namespace EncryptionLayer.Map
{
    public class CyberRoomMap : IVisualAutomaton
    {
        private readonly List<Tile> _tiles = new List<Tile>();

        public void Add(Tile tile)
        {
            _tiles.Add(tile);
        }

        public void Add(IEnumerable<Tile> tiles)
        {
            _tiles.AddRange(tiles);
        }

        public bool Exist(TileLocation loc)
        {
            return _tiles.Any(x => x.Location.Equals(loc));
        }

        public Tile Get(TileLocation loc)
        {
            return _tiles.First(x => x.Location.Equals(loc));
        }

        public void Update(TimeSpan delta)
        {
            _tiles.OrderBy(x => x.Layer).ForEach(x => x.Update(delta));
        }

        public void Draw(Vector2 offset)
        {
            _tiles.OrderBy(x => x.Layer).ForEach(x => x.Draw(offset));
        }
    }
}
