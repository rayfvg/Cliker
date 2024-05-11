using ScriptBank;
using ScriptsPlayer;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Upgrade;

public class BuyChangetSword2 : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    [SerializeField] private Sprite _weaponSkins;
    [SerializeField] private Player _player;
    [SerializeField] private Bank _bank;
    [SerializeField] private int _newWeaponCount;
    [SerializeField] private AutoAttack _autoAttack;
    [SerializeField] private TMP_Text _countNewSword;


    private void Update()
    {
        _countNewSword.text = _newWeaponCount.ToString();
    }

    public void BuyNewWeapon1()
    {
        if (_bank.Money >= _newWeaponCount)
        {
            _bank.Money -= _newWeaponCount;
            var imageWeapon = _weapon.GetComponent<SpriteRenderer>();
            imageWeapon.sprite = _weaponSkins;
            _player.PlayerDamage += 3;
            _autoAttack._autoMoneyLevel = 5;

        }
    }
}
