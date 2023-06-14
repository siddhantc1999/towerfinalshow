using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public GameObject selectedWeapon;
    public GameObject setselectedWeapon
    {
        get { return selectedWeapon; }
    }
    public event Action WeaponChangedEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WeaponChange(GameObject Weapon)
    {
        selectedWeapon = Weapon;
        WeaponChangedEvent?.Invoke();
    }
    
}
