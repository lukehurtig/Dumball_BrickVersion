using Microsoft.Xna.Framework;

namespace ParticleSystem
{
    public interface IParticleEmitter
    {
        public Vector2 Position { get; set; }

        public Vector2 Velocity { get; set; }
    }
}
