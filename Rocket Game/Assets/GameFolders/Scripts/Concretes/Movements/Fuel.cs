using RocketGame.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketGame.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel = 100f;
        [SerializeField] float _currentFuel;
        [SerializeField] ParticleSystem _particle;

        public bool IsEmpty => _currentFuel < 1f;
        public float CurrentFuel => _currentFuel / _maxFuel;

        private void Awake()
        {
            _currentFuel = _maxFuel;
        }
        
        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel,_maxFuel);

            if (_particle.isPlaying)
            {
                _particle.Stop();
            }

            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel,0f);

            if (_particle.isStopped)
            {
                _particle.Play();
            }
            SoundManager.Instance.PlaySound(0);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Fuel"))
            {
                Fuel currentFuel = other.GetComponent<Fuel>();
                if (currentFuel != null)
                {
                    currentFuel._currentFuel = currentFuel._maxFuel;
                }
            }
        }





    }

}

