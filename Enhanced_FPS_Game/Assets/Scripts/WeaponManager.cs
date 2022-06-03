using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject[] weapons;
    int weaponIndex = 0;

    private void Awake()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        } // End for.
    } // End Awake.

    void Update()
    {
        weapons[weaponIndex].SetActive(true);
        if (Input.GetKeyDown("1"))
        {
            if (weaponIndex >= weapons.Length - 1)
            {
                weapons[weaponIndex].SetActive(false);
                weaponIndex = 0;
                weapons[weaponIndex].SetActive(true);
            } // End if.
            else
            {
                weaponIndex++;
                weapons[weaponIndex].SetActive(true);
                weapons[weaponIndex - 1].SetActive(false);
            } // End else.
        } // End if.
    } // End Update.
} // End script.
