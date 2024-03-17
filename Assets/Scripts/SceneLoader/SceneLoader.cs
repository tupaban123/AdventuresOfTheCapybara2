using Adventure.CodeBase;
using Adventure.Constants;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Adventure.SceneLoading
{
    public class SceneLoader : ISceneLoader
    {
        private ICoroutineRunner _coroutineRunner;

        public event Action<float> ProgressChanged;
        public event Action StartLoadScene;

        public SceneLoader(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }

        public void LoadGame()
        {
            _coroutineRunner.StartCoroutine(LoadSceneAsync(SceneConstants.GameSceneName));
        }

        public void LoadMenu()
        {
            _coroutineRunner.StartCoroutine(LoadSceneAsync(SceneConstants.MenuSceneName));
        }

        public void Restart()
        {
            _coroutineRunner.StartCoroutine(LoadSceneAsync(SceneConstants.GameSceneName));
        }

        private IEnumerator LoadSceneAsync(string sceneName)
        {
            StartLoadScene?.Invoke();

            AsyncOperation sceneLoadingProgress = SceneManager.LoadSceneAsync(SceneConstants.LoadingSceneName);

            while(!sceneLoadingProgress.isDone)
                yield return null;

            AsyncOperation sceneLoadProgress = SceneManager.LoadSceneAsync(sceneName);

            while(sceneLoadProgress.isDone)
            {
                ProgressChanged?.Invoke(sceneLoadProgress.progress / .9f);
                yield return null;
            }
        }
    }
}