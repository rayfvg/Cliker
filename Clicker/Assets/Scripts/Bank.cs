using TMPro;
using UnityEngine;

namespace ScriptBank
{
    public class Bank : MonoBehaviour
    {
        public int Money { get => _money; set => _money = value; }

        [SerializeField] private TMP_Text _moneyText;

        private int _money = 0;

        private void Update()
        {
            _moneyText.text = _money.ToString();
        }
    }
}