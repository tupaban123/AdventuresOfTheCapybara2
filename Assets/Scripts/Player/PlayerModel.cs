using Adventure.Player.Configs;
using UnityEngine;

namespace Adventure.Player
{
    public class PlayerModel
    {
        private PlayerMovementView _movementView;
        private PlayerConfig _config;

        public PlayerModel(PlayerMovementView movementView, PlayerConfig config)
        {
            _movementView = movementView;
            _config = config;
        }

        public void OnMove(Vector2 input)
        {
            _movementView.MovePlayer(input * _config.Speed);
        }
    }
}