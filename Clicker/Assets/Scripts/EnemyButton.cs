using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Enemy
{
    public class EnemyButton : MonoBehaviour
    {
        public int EnemyHealth = 1000;
        public int MaxHealth = 1000;

        [SerializeField] private HeathBar _healthBar;
        [SerializeField] private TMP_Text _healthBarText;

        [SerializeField] private Button _imageEnemy;
        [SerializeField] private Sprite[] _imageMassive;

        [SerializeField] private int Count;



        private void Update()
        {
            _healthBarText.text = EnemyHealth.ToString();

            if (EnemyHealth <= 0)
            {
                Count++;
                Dead(Count);
                if (Count == 12) NewGamePrestige();
            }
        }

        public void Dead(int index)
        {
            _imageEnemy.image.sprite = _imageMassive[index];
            EnemyHealth = 1000;
        }
        public void NewGamePrestige()
        {
            _imageEnemy.image.sprite = _imageMassive[0];
            EnemyHealth = 1000;
            Count = 0;
        }

    }
}