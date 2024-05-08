using UnityEngine;
using UnityEngine.UI;

namespace Enemy
{
    public class HeathBar : MonoBehaviour
    {
        [SerializeField] public Slider Slider;
        [SerializeField] private EnemyButton _enemy;

        private void Update()
        {
            ChangeHealthValue();
        }

        public void ChangeHealthValue()
        {
            Slider.value = (float)_enemy.EnemyHealth / _enemy.MaxHealth;
        }
    }
}