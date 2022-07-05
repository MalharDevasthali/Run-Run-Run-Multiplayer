using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Scripts.Commons;

namespace Scripts.UIServices
{
    public class UIService : GenericSinglton<UIService>
    {
        [SerializeField] private TMP_Text scoreText;


        public void UpdateScore(int score)
        {
            scoreText.text = "Score : " + score;
        }
    }


}
