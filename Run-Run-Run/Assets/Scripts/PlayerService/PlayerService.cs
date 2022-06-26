using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Commons;

namespace Scripts.PlayerService
{
    public class PlayerService : GenericSinglton<PlayerService>
    {
        public PlayerScriptableObject playerScriptableObject;

  
        private void Start()
        {
            createPlayer();
        }


        private void createPlayer()
        {
           
            PlayerModel playerModel = new PlayerModel(playerScriptableObject);
            PlayerController playerController = new PlayerController(playerScriptableObject.playerView, playerModel);
        }

    }

}