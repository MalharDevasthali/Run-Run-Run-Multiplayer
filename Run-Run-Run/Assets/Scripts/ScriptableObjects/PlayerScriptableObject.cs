using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.PlayerServices
{
    [CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObjects/PlayerScriptableObject")]
    public class PlayerScriptableObject : ScriptableObject
    {
        [Header("Player Properties")]
        public float movementSpeed;
        public int health;
        public int attackPower;
        public int score;

        [Header("Player MVC Essentials")]
        public PlayerView playerView;

    }
}