using Adventure.CodeBase;
using Adventure.SceneLoading;

using UnityEngine;
using UnityEngine.UI;

namespace Adventure.LoadingUI
{
    public class LoadingProgressUI : MonoBehaviour
    {
        [SerializeField] private Image _progressBar;

        private ISceneLoader _sceneLoader;

        private void Start()
        {
            _sceneLoader = ServiceLocator.Instance.Get<ISceneLoader>();
            _sceneLoader.ProgressChanged += OnProgressChanged;
        }

        private void OnDestroy()
        {
            if( _sceneLoader != null )
                _sceneLoader.ProgressChanged -= OnProgressChanged;
        }

        private void OnProgressChanged(float progress)
        {
            _progressBar.fillAmount = progress;
        }
    }
}