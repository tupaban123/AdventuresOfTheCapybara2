using UnityEngine;
using Adventure.InputSystem;

namespace Adventure.CodeBase
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private Joystick _joystick;

        private IInputSystem _inputSystem;

        private void Start()
        {
            _inputSystem = new AndroidInputSystem(_joystick);
        }
    }
}
