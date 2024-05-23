using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/02/2024]
 * [A weapon that is attached to the bike with a range, firing rate, strength, and cooldown]
 */

public class Weapon : IWeapon
{
    //the weapons configuration that was made
    private readonly WeaponConfig config;

    //a property for the range of the weapon that implements the configs range value
    public float Range
    {
        get { return config.Range; }
    }

    //a property for the firing rate of the weapon that implements the configs firing rate value
    public float FiringRate
    {
        get { return config.FiringRate; }
    }

    //a property for the strength of the weapon that implements the configs strength value
    public float Strength
    {
        get { return config.Strength; }
    }

    //a property for the cooldown of the weapon that implements the configs cooldown value
    public float Cooldown
    {
        get { return config.Cooldown; }
    }

    /// <summary>
    /// Sets the weapons config to the passed in weapon configuration
    /// </summary>
    /// <param name="weaponConfig"> the configuration of the weapon that is passed into the weapon when it is created </param>
    public Weapon(WeaponConfig weaponConfig)
    {
        //set the configuration of the weapon to the weapon config that is passed in
        config = weaponConfig;
    }
}
