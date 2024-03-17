using Adventure.CodeBase;
using System;

namespace Adventure.SceneLoading
{
    public interface ISceneLoader : IService
    {
        event Action<float> ProgressChanged;
        event Action StartLoadScene;

        void LoadMenu();
        void LoadGame();
        void Restart();
    }
}