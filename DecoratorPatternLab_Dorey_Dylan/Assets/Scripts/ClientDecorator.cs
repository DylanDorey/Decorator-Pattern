using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/02/2024]
 * [The client component that allows the user to interact with the demo]
 */

public class ClientDecorator : MonoBehaviour
{
    //reference to the bike weapon
    private BikeWeapon bikeWeapon;

    //determines if the weapon is decorated
    private bool isWeaponDecorated;

    private void Start()
    {
        //initialize the bike weapon as the found component of type BikeWeapon, also casted as a BikeWeapon component
        bikeWeapon = (BikeWeapon)FindObjectOfType(typeof(BikeWeapon));
    }

    /// <summary>
    /// TESTING PURPOSES ONLY ( DO NOT USE IN PRODUCTION CODE ) EXTREMELY INEFFICIENT
    /// </summary>
    private void OnGUI()
    {
        //if the weapon is not decorated
        if(!isWeaponDecorated)
        {
            //create a decorate weapon button
            if (GUILayout.Button("Decorate Weapon"))
            {
                //if pressed, decorate the weapon with attachments and set isWeaponDecorated to true
                bikeWeapon.Decorate();
                isWeaponDecorated = !isWeaponDecorated;
            }
        }

        //if the weapon is decorated
        if (isWeaponDecorated)
        {
            //create a reset weapon button
            if (GUILayout.Button("Reset Weapon"))
            {
                //if pressed, remove all attachment from the weapon and set isWeaponDecorated to false
                bikeWeapon.Reset();
                isWeaponDecorated = !isWeaponDecorated;
            }
        }

        //create a toggle fire button
        if (GUILayout.Button("Toggle Fire"))
        {
            //if pressed, fire the weapon
            bikeWeapon.ToggleFire();
        }
    }
}
