using System;
using RocketGame.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RocketGame.Controller;

namespace RocketGame.Abstracts.Controller
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if(player !=null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}


