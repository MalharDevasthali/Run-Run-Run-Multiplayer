using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.PlayerService
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerController playerController;

        public void SetPlayerController(PlayerController playerController)
        {
            this.playerController = playerController;
        }
    }
}