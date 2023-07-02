using RocketGame.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace RocketGame.UIs
{
    public class GameOverObject : MonoBehaviour
    {   
        [SerializeField] GameObject _gameOverPanel;

        private void Awake()
        {
            if( _gameOverPanel.activeSelf )
            {
                _gameOverPanel.SetActive( false );
            }

        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }

        private void HandleOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive( true );
<<<<<<< HEAD
                Time.timeScale = 0;
=======
>>>>>>> 0d5b074fc9bdef9970f749bb98eca66872c8d75e
            }
        }

        
    }
}

