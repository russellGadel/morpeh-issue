using Scellecs.Morpeh;

namespace Logic
{
    public abstract class EcsUpdateSystem : ISystem
    {
        public World World { get; set; } = World.Default!;

        public abstract void OnAwake();

        public abstract void OnUpdate(float deltaTime);

        public virtual void Dispose()
        {
        }
    }
}