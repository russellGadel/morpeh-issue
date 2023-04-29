using UnityEngine;
using UnityEngine.SceneManagement;

namespace Logic
{
    public class OpenScene : MonoBehaviour
    {
        public void LoadSceneAsync(string scene)
        {
            SceneManager.LoadSceneAsync(scene);
        }
    }
}