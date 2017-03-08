using MonoDragons.Core.Render;
using MonoDragons.Core.Engine;

namespace EncryptionLayer.Player
{
    public sealed class PlayerCharacterAnimations : Animations
    {
        public PlayerCharacterAnimations()
            : base(Get(), "Up-False") { }

        private static Map<string, Animation> Get()
        {
            var downFalse = new Animation(180, "Images/Character/d1");
            var downTrue = new Animation(180, "Images/Character/d1");
            //var downTrue = new Animation(180,
            //    "Character/nami-d1",
            //    "Character/nami-d2",
            //    "Character/nami-d3",
            //    "Character/nami-d4");

            var leftFalse = new Animation(180, "Images/Character/l1");
            var leftTrue = new Animation(180, "Images/Character/l1");
            //var leftTrue = new Animation(180,
            //    "Character/nami-l1",
            //    "Character/nami-l2",
            //    "Character/nami-l3",
            //    "Character/nami-l4");

            var rightFalse = new Animation(180, "Images/Character/r1");
            var rightTrue = new Animation(180, "Images/Character/r1");
            //var rightTrue = new Animation(180,
            //    "Character/nami-r1",
            //    "Character/nami-r2",
            //    "Character/nami-r3",
            //    "Character/nami-r4");

            var upFalse = new Animation(180, "Images/Character/u1");
            var upTrue = new Animation(180, "Images/Character/u1");
            //var upTrue = new Animation(180,
            //    "Sprites/Character/nami-u1",
            //    "Sprites/Character/nami-u2",
            //    "Sprites/Character/nami-u3",
            //    "Sprites/Character/nami-u4");

            var animStates = new Map<string, Animation>
            {
                { "Down-False", downFalse },
                { "Down-True", downTrue },
                { "Left-False", leftFalse },
                { "Left-True", leftTrue },
                { "Right-False", rightFalse },
                { "Right-True", rightTrue },
                { "Up-False", upFalse },
                { "Up-True", upTrue },
            };

            return animStates;
        }
    }
}
