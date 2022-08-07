using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimDistance : MonoBehaviour
{
    public Slider aim_sistance;

    private void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Minus) || (Input.GetKey(KeyCode.KeypadMinus)))
        {
            aim_sistance.value -= 1f;
        }
        if ((Input.GetKey(KeyCode.KeypadPlus)))
        {
            aim_sistance.value += 1f;
        }
    }
}
