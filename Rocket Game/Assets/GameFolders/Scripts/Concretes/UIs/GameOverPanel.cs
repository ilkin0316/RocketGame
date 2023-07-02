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
<<<<<<< HEAD
            Time.timeScale = 1;
=======
>>>>>>> 0d5b074fc9bdef9970f749bb98eca66872c8d75e
        }

        public void NoClicked()
        {
            GameManager.Instance.LoadMenuScene();
<<<<<<< HEAD
            Time.timeScale = 1;
=======
>>>>>>> 0d5b074fc9bdef9970f749bb98eca66872c8d75e
        }
    }
}


