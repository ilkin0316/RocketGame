using RocketGame.Managers;
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

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Fuel"))
            {
                _currentFuel += 1000f; // Yakıt miktarını artır
                _currentFuel = Mathf.Min(_currentFuel, _maxFuel); // Yakıt miktarını maxFuel değerinden fazla olmayacak şekilde sınırla
                Destroy(other.gameObject); // Yakıt objesini yok et
            }
        }

        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);

            if (_particle.isPlaying)
            {
                _particle.Stop();
            }

            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0f);

            if (_particle.isStopped)
            {
                _particle.Play();
            }

            SoundManager.Instance.PlaySound(0);
        }
    }
}