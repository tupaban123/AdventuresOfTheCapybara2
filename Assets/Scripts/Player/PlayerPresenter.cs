using UnityEngine;

namespace Adventure.Player
{
    public class PlayerPresenter
    {
        private PlayerModel _model;

        public PlayerPresenter(PlayerModel model)
        {
            _model = model;
        }

        public void OnMoveInput(Vector2 input)
        {
            _model.OnMove(input);
        }
    }
}