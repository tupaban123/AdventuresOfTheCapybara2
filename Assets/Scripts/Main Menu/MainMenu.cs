using Adventure.CodeBase;
using Adventure.SceneLoading;
using UnityEngine;

namespace Adventure.MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        public void LoadGame() => ServiceLocator.Instance.Get<ISceneLoader>().LoadGame();
    }
}