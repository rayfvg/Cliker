using ScriptBank;
using ScriptsPlayer;
using System;
using System.Collections;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

namespace Upgrade
{
    public class AutoAttack : MonoBehaviour
    {
        [SerializeField] private int _autoAttackCount;
        [SerializeField] private Bank _bank;
        [SerializeField] private Player _player;
        [SerializeField] private int _autoMoneyLevel;
        [SerializeField] private TMP_Text _text;
        [SerializeField] private int _timerForAutoFarm;

       
        public void BuyAutoAttack()
        {
            if (_bank.Money >= _autoAttackCount)
            {
                _bank.Money =-_autoAttackCount;
                StartCoroutine(StartAutoFarm());
                _autoMoneyLevel += 3;
                _autoAttackCount += 100;
                _text.text = _autoAttackCount.ToString();
            }
  

        }
        IEnumerator StartAutoFarm()
        {
            yield return new WaitForSeconds(_timerForAutoFarm);
            _bank.Money += _autoMoneyLevel;
            StartCoroutine(StartAutoFarm());
        }
    }
}
