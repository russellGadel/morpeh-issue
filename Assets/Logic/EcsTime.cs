using Scellecs.Morpeh;

namespace Logic
{
    public class EcsTime : EcsUpdateSystem
    {
        private Filter filter = default!;

        public override void OnAwake()
        {
            filter = World
                .Filter
                .With<CTimer>();
        }

        public override void OnUpdate(float deltaTime)
        {
            foreach (var timerEntity in filter)
            {
                ref var timer = ref timerEntity.GetComponent<CTimer>();

                timer.Value += deltaTime;
            }
        }
    }
}