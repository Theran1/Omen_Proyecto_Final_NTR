using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    public bool HasDoneX = false;
    public bool HasKey = false;   

    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame) HasKey = !HasKey;
        if (Keyboard.current.xKey.wasPressedThisFrame) HasDoneX = !HasDoneX;
    }
}
