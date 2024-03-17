using Adventure.SceneLoading;

namespace Adventure.CodeBase
{
    public class Game
    {
        private readonly ICoroutineRunner _coroutineRunner;

        public Game(ICoroutineRunner coroutineRunner) 
        {
            _coroutineRunner = coroutineRunner;
        }

        public void RegisterServices()
        {
            ISceneLoader sceneLoader = new SceneLoader(_coroutineRunner);
            ServiceLocator.Instance.Register<ISceneLoader>(sceneLoader);
        }

        public void LoadGameScene()
        {
            ServiceLocator.Instance.Get<ISceneLoader>().LoadGame();
        }

        public void LoadMenuScene()
        {
            ServiceLocator.Instance.Get<ISceneLoader>().LoadMenu();
        }
    }
}