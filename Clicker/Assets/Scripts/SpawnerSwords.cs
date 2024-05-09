using UnityEngine;

namespace SpawnerSwprds
{
    public class SpawnerSwords : MonoBehaviour
    {
        [SerializeField] private GameObject[] _swordMassive;



       
        public void SpawnSword()
        {
            Instantiate(_swordMassive[1]);
        }
    }
}
