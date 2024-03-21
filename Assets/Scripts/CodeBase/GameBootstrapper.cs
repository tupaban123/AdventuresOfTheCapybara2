using UnityEngine;
using Adventure.InputSystem;
using Adventure.Player;

namespace Adventure.CodeBase
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private Joystick _joystick;
        [SerializeField] private PlayerMovementView _playerMovementView;

        private IInputSystem _inputSystem;

        private void Start()
        {
            _inputSystem = new AndroidInputSystem(_joystick);
            _playerMovementView.Initialize(_inputSystem);
        }
    }
}
