using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    public bool HasKey = false;
    public bool HasPotato = false;

    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame) HasKey = !HasKey;
        if (Keyboard.current.xKey.wasPressedThisFrame) HasPotato = !HasPotato;
    }

    public void SetPotato(bool potato)
    {
        HasPotato = potato;
    }
}
