using ScriptBank;
using ScriptsPlayer;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Upgrade { 
public class Upgrade : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Bank bank;
    [SerializeField] private int _valueBuyUpgrade;
    [SerializeField] private TMP_Text _valueBuyUpgradeText;

    private void Update()
    {
        _valueBuyUpgradeText.text = _valueBuyUpgrade.ToString();
    }
    public void UpgradeAttack()
    {
        if (bank.Money >= _valueBuyUpgrade)
        {
            _player.PlayerDamage += 1;
            bank.Money -= _valueBuyUpgrade;
            _valueBuyUpgrade += 30;

        }
        
    }

    public void CheckBuy()
    {
        
    }
}
}
