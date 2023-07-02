using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RocketGame.Managers;

namespace RocketGame.UIs
{
    public class PausePanel : MonoBehaviour
    {
        public GameObject pausep;
        public GameObject pauseButton;

        void Start()
        {
            pausep.SetActive(false);

        }

        public void butondan_gelen(string ne_geldi)
        {
            if (ne_geldi =="pause")
            {
                pausep.SetActive(true);
                pauseButton.SetActive(false);
                Time.timeScale = 0;
            }
            else if (ne_geldi =="resume")
            {
                pausep.SetActive(false);
                pauseButton.SetActive(true);
                Time.timeScale = 1;
            }

            else if (ne_geldi == "MainMenu")
            {
                Application.LoadLevel(0);
            }
            else if (ne_geldi == "LevelMenu")
            {
                Application.LoadLevel(1);
            }
        }
    }
}


