namespace Adventure.InputSystem
{
    public class AndroidInputSystem : IInputSystem
    {
        private Joystick _joystick;

        public float Horizontal => _joystick.Horizontal;

        public float Vertical => _joystick.Vertical;

        public AndroidInputSystem(Joystick joystick)
        {
            _joystick = joystick;
        }
    }
}