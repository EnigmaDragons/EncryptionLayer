using System;
using System.Collections.Generic;
using System.Linq;
using EncryptionLayer.Player;
using Microsoft.Xna.Framework;
using MonoDragons.Core.Common;
using MonoDragons.Core.Engine;
using MonoDragons.Core.PhysicsEngine;

namespace EncryptionLayer.Map
{
    public class CyberRoomMap : IVisualAutomaton, ICharSpace
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

        public void Draw(Transform parentTransform)
        {
            _tiles.OrderBy(x => x.Layer).ForEach(x => x.Draw(parentTransform));
        }

        public Transform ApplyMove(Transform transform, Vector2 moveBy)
        {
            return transform + moveBy;
        }
    }
}
