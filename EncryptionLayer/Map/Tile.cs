﻿using System;
using Microsoft.Xna.Framework;
using MonoDragons.Core.Engine;

namespace EncryptionLayer.Map
{
    public class Tile
    {
        public string TextureName { get; }
        public TileLocation Location { get; }
        public bool IsBlocking { get; }
        public int Layer { get; }

        public Tile(string textureName, TileLocation loc, bool blocking, int layer = 0)
        {
            TextureName = "Images/Map/" + textureName;
            Location = loc;
            IsBlocking = blocking;
            Layer = layer;
        }

        public virtual void Update(TimeSpan delta)
        {
        }

        public virtual void Draw(Vector2 offset)
        {
            World.Draw(TextureName, new Rectangle(Location.RenderPosition.ToPoint(), new Point(TileSize.RenderSize, TileSize.RenderSize)));
        }
    }
}
