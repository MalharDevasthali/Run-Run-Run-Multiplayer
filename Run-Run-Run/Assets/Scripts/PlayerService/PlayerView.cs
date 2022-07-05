using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.PlayerServices
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerController playerController;

        private Rigidbody2D rb2d;


        private void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        public void SetPlayerController(PlayerController playerController)
        {
            this.playerController = playerController;
        }

        private void Update()
        {

            playerController.Move(rb2d, new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        }
    }
}