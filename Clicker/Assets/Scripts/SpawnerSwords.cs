using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSwords : MonoBehaviour
{
    [SerializeField] private Sprite SwordMassive;

    public void SpawnSword()
    {
        Instantiate(SwordMassive, transform.position, Quaternion.identity, transform);
    }
}
