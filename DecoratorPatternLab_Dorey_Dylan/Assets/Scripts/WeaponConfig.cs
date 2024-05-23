using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/02/2024]
 * [A weapon configuration scriptable object that creates a weapon with predefined attachment configurations]
 */

[CreateAssetMenu(fileName = "Weapon Configuration", menuName = "Weapon/Configuration", order = 2)]
public class WeaponConfig : ScriptableObject, IWeapon
{
    //variables for the fire rate, range, strength, and cooldown of the weapon
    [Range(0, 60)]
    [Tooltip("Rate of fire per second")]
    [SerializeField]
    private float firingRate;

    [Range(0, 50)]
    [Tooltip("Weapon Range")]
    [SerializeField]
    private float range;

    [Range(0, 100)]
    [Tooltip("Weapon Strength")]
    [SerializeField]
    private float strength;

    [Range(0, -5)]
    [Tooltip("Cooldown Duration")]
    [SerializeField]
    private float cooldown;


    //the name and description of the weapon
    public string weaponName;
    public string weaponDescription;

    //the weapon prefab (if this was an actual game)
    public GameObject weaponPrefab;

    //property to access the weapons's firing rate
    public float FiringRate
    {
        get { return firingRate; }
    }

    //property to access the weapons's range
    public float Range
    {
        get { return range; }
    }

    //property to access the weapons's strength
    public float Strength
    {
        get { return strength; }
    }

    //property to access the weapons's cooldown
    public float Cooldown
    {
        get { return cooldown; }
    }
}
