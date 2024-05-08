using ScriptsPlayer;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Player _player;
    public void UpgradeAttack()
    {
        _player.PlayerDamage = 200;
    }
}
