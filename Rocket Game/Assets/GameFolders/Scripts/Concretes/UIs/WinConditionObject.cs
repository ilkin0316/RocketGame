using RocketGame.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketGame.UIs
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject _winConditionPanel;

        private void Awake()
        {
            if (_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }



        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }

        private void HandleOnMissionSucced()
        {
            if (!_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(true);
            }
        }

        public void level1Finish()
        {
            MenuManager.level2 = true;
        }

        public void level2Finish()
        {
            MenuManager.level3 = true;
        }

        public void level3Finish()
        {
            MenuManager.level4 = true;
        }

        public void level4Finish()
        {
            MenuManager.level5 = true;
        }

        public void level5Finish()
        {
            MenuManager.level6 = true;
        }

        public void level6Finish()
        {
            MenuManager.level7 = true;
        }

        public void level7Finish()
        {
            MenuManager.level8 = true;
        }

        public void level8Finish()
        {
            MenuManager.level9 = true;
        }

        public void level9Finish()
        {
            MenuManager.level10 = true;
        }

        public void level10Finish()
        {
            MenuManager.level11 = true;
        }

        public void level11Finish()
        {
            MenuManager.level12 = true;
        }

        public void level12Finish()
        {
            MenuManager.level13= true;
        }

        public void level13Finish()
        {
            MenuManager.level14 = true;
        }

        public void level14Finish()
        {
            MenuManager.level15 = true;
        }

        public void level15Finish()
        {
            MenuManager.level16 = true;
        }

        public void level16Finish()
        {
            MenuManager.level17 = true;
        }

        public void level17Finish()
        {
            MenuManager.level19= true;
        }

        public void level18Finish()
        {
            MenuManager.level19 = true;
        }

        public void level19Finish()
        {
            MenuManager.level20 = true;
            
        }
        public void level20Finish()
        {
            MenuManager.level20 = true;
            SceneManager.LoadScene(20);
        }
    }

}


