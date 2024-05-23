using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/02/2024]
 * [A bike weapon that can shoot and is customizable by the player]
 */

public class BikeWeapon : MonoBehaviour
{
    //reference to the bike weapon's desired weapon configuration setup
    public WeaponConfig weaponConfig;

    //reference to the bike weapon's two attachments
    public WeaponAttachment mainAttachment;
    public WeaponAttachment secondaryAttachment;

    //determines if the bike weapon is shooting or not
    private bool isFiring;

    //determines if the bike weapon is decorated with attachments or not
    private bool isDecorated;

    //the weapon that will be altered by the attachments
    private IWeapon weapon;

    private void Start()
    {
        //create a new blank weapon
        weapon = new Weapon(weaponConfig);
    }

    /// <summary>
    /// fires the weapon on the bike
    /// </summary>
    public void ToggleFire()
    {
        //toggle the isFiring variable to on/off
        isFiring = !isFiring;

        //if the weapon is firing
        if (isFiring)
        {
            //start the fire weapon coroutine/fire the weapon
            StartCoroutine(FireWeapon());
        }
    }

    /// <summary>
    /// Debugs out that the weapon has been fired
    /// </summary>
    /// <returns> the fire rate of the weapon/time between shots </returns>
    private IEnumerator FireWeapon()
    {
        //initialize the fireRate variable of the weapon
        float firingRate = 1.0f / weapon.FiringRate;

        //while the weapon is firing
        while (isFiring)
        {
            //wait the time between shots/fireRate
            yield return new WaitForSeconds(firingRate);

            //Fire the weapon once
            Debug.Log("Fire");
        }
    }

    public void Reset()
    {
        //reset the weapon to a new weapon
        weapon = new Weapon(weaponConfig);

        //set isDecorated to not isDecorated
        isDecorated = !isDecorated;
    }

    /// <summary>
    /// Decorates the bike weapon that is created
    /// </summary>
    public void Decorate()
    {
        //if the weapon has a main attachment but doesnt have a secondary attachment
        if (mainAttachment && !secondaryAttachment)
        {
            //create the new weapon with only the main attachment
            weapon = new WeaponDecorator(weapon, mainAttachment);
        }

        //if the weapon has a main attachment and a secondary attachment
        if (mainAttachment && secondaryAttachment)
        {
            //create the new weapon with a main attachment then add the secondary attachment
            weapon = new WeaponDecorator(new WeaponDecorator(weapon, mainAttachment), secondaryAttachment);
        }

        //set is decorated to true
        isDecorated = !isDecorated;
    }

    /// <summary>
    /// TESTING PURPOSES ONLY ( DO NOT USE IN PRODUCTION CODE ) EXTREMELY INEFFICIENT
    /// </summary>
    private void OnGUI()
    {
        //change the UI color to green
        GUI.color = Color.green;

        //create labels for the weapons range, strength, cooldown, firing rate, and if the weapon is firing
        GUI.Label(new Rect(5, 50, 150, 100), "Range: " + weapon.Range);
        GUI.Label(new Rect(5, 70, 150, 100), "Strength: " + weapon.Strength);
        GUI.Label(new Rect(5, 90, 150, 100), "Cooldownh: " + weapon.Cooldown);
        GUI.Label(new Rect(5, 110, 150, 100), "Firing Rate: " + weapon.FiringRate);
        GUI.Label(new Rect(5, 130, 150, 100), "Weapon Firing: " + isFiring);

        //if the weapon has a main attachment and isDecorated
        if (mainAttachment && isDecorated)
        {
            //display the main attachment on the weapon
            GUI.Label(new Rect(5, 150, 150, 100), "Main Attachment: " + mainAttachment.name);
        }

        //if the weapon has a secondary attachment and isDecorated
        if (secondaryAttachment && isDecorated)
        {
            //display the secondary attachment on the weapon
            GUI.Label(new Rect(5, 170, 150, 100), "Sceondary Attachment: " + secondaryAttachment.name);
        }
    }
}
