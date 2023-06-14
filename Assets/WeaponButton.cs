using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponButton : MonoBehaviour
{
    [SerializeField] GameObject Weapon;
    WeaponSelect weaponSelect;
    private void Awake()
    {
        weaponSelect = FindObjectOfType<WeaponSelect>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnWeaponButtonClick()
    {
        weaponSelect.WeaponChange(Weapon);
    }
  
}
