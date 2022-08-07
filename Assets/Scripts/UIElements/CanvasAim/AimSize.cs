using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimSize : MonoBehaviour
{
    public Slider aim_size;

    private void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Minus) || (Input.GetKey(KeyCode.KeypadMinus)))
        {
            aim_size.value -= 1f;
        }
        if ((Input.GetKey(KeyCode.KeypadPlus)))
        {
            aim_size.value += 1f;
        }
    }
}
