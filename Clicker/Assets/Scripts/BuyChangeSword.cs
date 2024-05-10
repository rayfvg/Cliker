using ScriptBank;
using ScriptsPlayer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyChangeSword : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    [SerializeField] private Sprite[] _weaponSkins;
    [SerializeField] private Player _player;
    [SerializeField] private Bank _bank;
    [SerializeField] private int _newWeaponCount;

    public void BuyNewWeapon()
    {
        if (_bank.Money >= _newWeaponCount)
        {
            var imageWeapon = _weapon.GetComponent<SpriteRenderer>();
            imageWeapon.sprite = _weaponSkins[1];
        }
    }
}
