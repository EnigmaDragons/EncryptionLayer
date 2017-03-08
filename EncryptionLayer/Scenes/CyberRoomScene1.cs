using System;
using EncryptionLayer.Map;
using Microsoft.Xna.Framework;
using MonoDragons.Core.Engine;

namespace EncryptionLayer.Scenes
{
    public class CyberRoomScene1 : IScene
    {
        private readonly CyberRoomMap _map = new CyberRoomMap();

        public void Init()
        {
            _map.Add(new TileWalker(0, 20, 0, 20).Get(x => new Tile("Images/Map/ground1", x, false)));
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
