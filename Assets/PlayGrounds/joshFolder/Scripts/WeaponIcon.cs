﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponIcon : MonoBehaviour
{
    public TMPro.TMP_Text weapon_label;
    // Start is called before the first frame update
    void Start()
    {
        weapon_label.text = "Axe";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
