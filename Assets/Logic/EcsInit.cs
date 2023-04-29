using Scellecs.Morpeh;
using UnityEngine;

namespace Logic
{
    public class EcsInit : MonoBehaviour
    {
        [SerializeField] GameObject ecsSecondsObject;

        private SystemsGroup coreGroup;
        private const int Order = 0;
        private EcsUpdateSystem exampleSystem;

        private void Awake()
        {
            if (World.Default == null)
            {
                WorldExtensions.InitializationDefaultWorld();
            }

            coreGroup = World.Default.CreateSystemsGroup();

            exampleSystem = new EcsTime();
            coreGroup.AddSystem(exampleSystem);

            World.Default.AddSystemsGroup(Order, coreGroup);

            ecsSecondsObject.AddComponent<PTimer>();
        }

        private void OnDestroy()
        {
            coreGroup.RemoveSystem(exampleSystem);
            World.Default.RemoveSystemsGroup(coreGroup);
            World.Default!.Dispose();
        }
    }
}