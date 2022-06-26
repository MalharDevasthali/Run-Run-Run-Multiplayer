using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.PlayerService
{
    [CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObjects/PlayerScriptableObject")]
    public class PlayerScriptableObject : ScriptableObject
    {
        [Header("Player Properties")]
        public float movementSpeed;
        public int health;
        public int attackPower;

        [Header("Player MVC Essentials")]
        public PlayerView playerView;

    }
}