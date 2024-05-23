using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/02/2024]
 * [A weapon attachment scriptable object that alters a weapons firing rate, range, stength, and cooldown]
 */

[CreateAssetMenu(fileName = "NewWeaponAttachment", menuName = "Weapon/Attachments", order = 1)]
public class WeaponAttachment : ScriptableObject, IWeapon
{
    //variables for the fire rate, range, strength, and cooldown changes the attachments make to the weapon
    [Range(0, 50)]
    [Tooltip("Increase rate of fire per second")]
    [SerializeField]
    public float firingRate;

    [Range(0, 50)]
    [Tooltip("Increase weapon range")]
    [SerializeField]
    public float range;

    [Range(0, 100)]
    [Tooltip("Increase weapon strength")]
    [SerializeField]
    public float strength;

    [Range(0, -5)]
    [Tooltip("Decrease cooldown duration")]
    [SerializeField]
    public float cooldown;
    
    //the name and description of the attachment
    public string attachmentName;
    public string attachmentDescription;

    //the attachment prefab (if this was an actual game)
    public GameObject attachmentPrefab;

    //property to access the attachment's firing rate change
    public float FiringRate
    {
        get { return firingRate; }
    }

    //property to access the attachment's range change
    public float Range
    {
        get { return range; }
    }

    //property to access the attachment's strength change
    public float Strength
    {
        get { return strength; }
    }

    //property to access the attachment's cooldown change
    public float Cooldown
    {
        get { return cooldown; }
    }
}
