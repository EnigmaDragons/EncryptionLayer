using System;
using EncryptionLayer.Map;
using Microsoft.Xna.Framework;
using MonoDragons.Core.Engine;
using MonoDragons.Core.Inputs;

namespace EncryptionLayer.Scenes
{
    public class CyberRoomScene1 : IScene
    {
        private readonly CyberRoomMap _map = new CyberRoomMap();

        public void Init()
        {
            Input.ClearBindings();
            _map.Add(new TileWalker(0, 20, 0, 20).Get(x => new Tile("ground2", x, false)));
            _map.Add(new TileWalker(0, 9, 0, 1).Get(x => new Tile("wall-h1", x, true, 1)));
            _map.Add(new TileWalker(11, 9, 0, 1).Get(x => new Tile("wall-h1", x, true, 1)));
            _map.Add(new Tile("stairs1", new TileLocation(9, 0), false, 1));
            _map.Add(new Tile("stairs2", new TileLocation(10, 0), false, 1));
            _map.Add(new Tile("loginhub1", new TileLocation(5, 5), true, 1));
            _map.Add(new Tile("loginhub2", new TileLocation(6, 5), true, 1));
            _map.Add(new Tile("loginhub3", new TileLocation(5, 6), true, 1));
            _map.Add(new Tile("loginhub4", new TileLocation(6, 6), true, 1));
        }

        public void Update(TimeSpan delta)
        {
            _map.Update(delta);
        }

        public void Draw()
        {
            _map.Draw(Vector2.Zero);
        }
    }
}
