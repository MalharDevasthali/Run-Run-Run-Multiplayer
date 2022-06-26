using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.PlayerService

{
    public class PlayerModel
    {
        public float movementSpeed { get; private set; }
        public int health { get; private set; }
        public int attackPower { get; private set; }


        private PlayerController playerController;

        public PlayerModel (PlayerScriptableObject scriptableObject)
        {
            movementSpeed = scriptableObject.movementSpeed;
            health = scriptableObject.health;
            attackPower = scriptableObject.attackPower;
        }


        public void SetPlayerController(PlayerController playerController)
        {
            this.playerController = playerController;
        }

    }   
}
