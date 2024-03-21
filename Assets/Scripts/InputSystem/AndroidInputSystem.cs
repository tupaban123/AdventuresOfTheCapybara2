using UnityEngine;

namespace Adventure.InputSystem
{
    public class AndroidInputSystem : IInputSystem
    {
        private Joystick _joystick;

        public Vector2 Axis => new Vector2(_joystick.Horizontal, _joystick.Vertical);

        public AndroidInputSystem(Joystick joystick)
        {
            _joystick = joystick;
        }
    }
}