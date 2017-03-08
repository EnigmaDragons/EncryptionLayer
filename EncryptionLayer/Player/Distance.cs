using System;

namespace EncryptionLayer.Player
{
    public sealed class Distance
    {
        private readonly float _deltaTimeMs;
        private readonly float _moveSpeed;

        public Distance(TimeSpan deltaTime, float moveSpeed)
            : this((float)deltaTime.TotalMilliseconds, moveSpeed) { }

        public Distance(float deltaTimeMs, float moveSpeed)
        {
            _deltaTimeMs = deltaTimeMs;
            _moveSpeed = moveSpeed;
        }

        public float Get()
        {
            return _deltaTimeMs * _moveSpeed;
        }
    }
}
