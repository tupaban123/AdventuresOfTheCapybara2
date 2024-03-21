using Adventure.InputSystem;
using Adventure.Player.Configs;
using UnityEngine;

namespace Adventure.Player
{
    public class PlayerMovementView : MonoBehaviour
    {
        [SerializeField] private PlayerConfig _playerConfig;
        [SerializeField] private Rigidbody2D _rb;

        private PlayerModel _model;
        private PlayerPresenter _presenter;

        private IInputSystem _inputSystem;

        public void Initialize(IInputSystem inputSystem)
        {
            if(_rb == null)
                _rb = GetComponent<Rigidbody2D>();

            _inputSystem = inputSystem;

            _model = new PlayerModel(this, _playerConfig);
            _presenter = new PlayerPresenter(_model);
        }

        private void Update()
        {
            _presenter.OnMoveInput(_inputSystem.Axis);
        }

        public void MovePlayer(Vector2 velocity)
        {
            _rb.velocity = velocity;
        }
    }
}
