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
        }

        public void NoClicked()
        {//rklerljgt
            GameManager.Instance.LoadMenuScene();
        }
    }
}


