using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Commons;
using Scripts.UIServices;

namespace Scripts.PlayerServices
{
    public class PlayerService : GenericSinglton<PlayerService>
    {
        public PlayerScriptableObject playerScriptableObject;

        private PlayerController playerController;
        private PlayerModel playerModel;


        private void Start()
        {
            createPlayer();
        }

        private void createPlayer()
        {
            playerModel = new PlayerModel(playerScriptableObject);
            playerController = new PlayerController(playerScriptableObject.playerView, playerModel);
        }

        public void UpdateScoreUI()
        {
            UIService.instance.UpdateScore(playerModel.score);
        }


        #region Getters
        public PlayerController GetPlayerController()
        {
            return playerController;
        }
        #endregion
    }

}