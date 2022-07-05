using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.PlayerServices

{
    public class PlayerModel
    {
        public float movementSpeed { get; private set; }
        public int health { get; private set; }
        public int attackPower { get; private set; }

        public int score { get; private set; }


        private PlayerController playerController;

        public PlayerModel(PlayerScriptableObject scriptableObject)
        {
            movementSpeed = scriptableObject.movementSpeed;
            health = scriptableObject.health;
            attackPower = scriptableObject.attackPower;
            score = scriptableObject.score;
        }


        public void SetPlayerController(PlayerController playerController)
        {
            this.playerController = playerController;
        }

        public void UpdateScore()
        {
            score++;
        }

    }
}
