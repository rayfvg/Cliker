using Enemy;
using ScriptBank;
using UnityEngine;

namespace ScriptsPlayer
{
    public class Player : MonoBehaviour
    {
        public int PlayerDamage { get => _playerDamage; set => _playerDamage = value; }

        [SerializeField] private Bank _money;
        [SerializeField] private EnemyButton _enemy;
        [SerializeField, Range(1, 100)] private int _playerDamage;
        [SerializeField] private SpawnerSwords _spawnerSwords;

        public void ApplyDamage()
        {
            _enemy.EnemyHealth -= _playerDamage;
            _spawnerSwords.SpawnSword();
            _money.Money += 10;
        }
    }
}