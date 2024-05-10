using ScriptBank;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace SpawnerSwprds
{
    public class SpawnerSwords : MonoBehaviour
    {
        [Header("PrefabOfSpawn")] 
        [SerializeField] private Sprite[] _prefabSpriteMassiv;

        [SerializeField] private Transform[] _spawnPoints;

        [SerializeField] private Transform _targerPoint;

        [SerializeField] private float _speedMovePrefab;

        [SerializeField] private Animator _animator;


        public void SpawnSword()
        {
           
            _animator.SetTrigger("Sword");

            
        }
        

        private void Update()
        {
            
        }
        
    }
}
