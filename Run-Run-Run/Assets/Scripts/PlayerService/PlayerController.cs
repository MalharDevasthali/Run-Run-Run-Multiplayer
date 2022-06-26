using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.PlayerService
{
    public class PlayerController
    {
        private PlayerView PlayerView;
        private PlayerModel playerModel;
 
        
        public PlayerController(PlayerView _playerView , PlayerModel _playerModel)
        {
            playerModel = _playerModel;
            PlayerView = GameObject.Instantiate<PlayerView>(_playerView);

            playerModel.SetPlayerController(this);
            PlayerView.SetPlayerController(this);
            
        }

        public void Move(Rigidbody2D rigidbody,Vector2 direction)
        {
            
            rigidbody.velocity = direction * playerModel.movementSpeed;
        }
    }
}