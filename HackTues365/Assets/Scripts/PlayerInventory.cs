﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool HasKey = false;

    public void PickUpKey() {
        HasKey = true;
        Debug.Log("Pick Key");
    }

}
