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


        public void Pass()
        {
            int currentLevel = SceneManager.GetActiveScene().buildIndex;

            if(currentLevel>= PlayerPrefs.GetInt("levelUnlocked"))
            {
                PlayerPrefs.SetInt("levelUnlocked", currentLevel + 1);
<<<<<<< HEAD
                
=======
>>>>>>> 0d5b074fc9bdef9970f749bb98eca66872c8d75e
            }
        }
        private void Awake()
        {
            if (_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(false);
<<<<<<< HEAD
                
=======
>>>>>>> 0d5b074fc9bdef9970f749bb98eca66872c8d75e
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
<<<<<<< HEAD
                
=======
>>>>>>> 0d5b074fc9bdef9970f749bb98eca66872c8d75e
            }
        }

    }

}


