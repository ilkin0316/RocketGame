using RocketGame.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketGame.Controller
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;
        [SerializeField] GameObject _finishLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null)
            {
                return;
            }

            if(other.GetContact(0).normal.y ==-1)
            {
                _finishFireWork.gameObject.SetActive(true);
                _finishLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                //GameOver
                GameManager.Instance.GameOver();
            }
        }
    }
}


