using RocketGame.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketGame.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();
            Time.timeScale = 1;
        }

        public void NoClicked()
        {
            GameManager.Instance.LoadMenuScene();
            Time.timeScale = 1;
        }
    }
}


