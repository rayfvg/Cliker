using Enemy;
using ScriptBank;
using SpawnerSwprds;
using UnityEngine;

namespace ScriptsPlayer
{
    public class Player : MonoBehaviour
    {
        private const string ATTACK = "Attack";

        public int PlayerDamage { get => _playerDamage; set => _playerDamage = value; }

        [SerializeField] private Bank _money;
        [SerializeField] private EnemyButton _enemy;
        [SerializeField, Range(1, 100)] private int _playerDamage;
        [SerializeField] private SpawnerSwords _spawnerSwords;
        [SerializeField] private Animator _animator;
        [SerializeField] private GameObject _blood;
        
        public void ApplyDamage()
        {
            _enemy.EnemyHealth -= _playerDamage;
            _money.Money += 1;
            _animator.SetTrigger(ATTACK);
            _blood.SetActive(true);
            _spawnerSwords.SpawnSword();
        }
       
    }
}