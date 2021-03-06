﻿using System;
using Microsoft.Xna.Framework;
using MonoDragons.Core.Engine;
using MonoDragons.Core.Inputs;
using MonoDragons.Core.PhysicsEngine;
using MonoDragons.Core.Render;

namespace EncryptionLayer.Player
{
    public class PlayerCharacter : IVisualAutomaton
    {
        // Movement
        private float moveSpeed = 0.12f;

        // Render Location
        private readonly ICharSpace _charSpace;
        private Transform _transform;

        // Collision
        private BoxCollider Collider => 
            new BoxCollider(new Rectangle(_transform.Location.ToPoint(), new Vector2(16 * _transform.Scale, 16 * _transform.Scale).ToPoint()));

        // Animations
        private readonly Animations _anims;
        private Direction _dir = new Direction();
        private string _facing = "Down";
        private bool IsMoving => _dir.HDir != HorizontalDirection.None || _dir.VDir != VerticalDirection.None;
        private string AnimState => $"{_facing}-{IsMoving}";

        public PlayerCharacter(ICharSpace charSpace, Transform startingLocation)
        {
            _anims = new PlayerCharacterAnimations();
            _transform = startingLocation;
            _charSpace = charSpace;
            Input.ClearBindings();
            Input.OnDirection(UpdatePhysics);
        }

        private void UpdatePhysics(Direction dir)
        {
            _dir = dir;

            if (!dir.HDir.Equals(HorizontalDirection.None))
                _facing = dir.HDir.ToString();
            if (!dir.VDir.Equals(VerticalDirection.None))
                _facing = dir.VDir.ToString();

            UpdateAnimState();
        }

        public void Update(TimeSpan delta)
        {
            _anims.Update(delta);
            var distance = new Physics().GetDistance(moveSpeed, delta);
            if (distance > 0)
                _transform = _charSpace.ApplyMove(_transform, Collider, new Movement(distance, _dir).GetDelta());
        }

        public void Draw(Transform parentTransform)
        {
            _anims.Draw(_transform + parentTransform);
        }

        private void UpdateAnimState()
        {
            _anims.SetState(AnimState);
        }
    }
}
