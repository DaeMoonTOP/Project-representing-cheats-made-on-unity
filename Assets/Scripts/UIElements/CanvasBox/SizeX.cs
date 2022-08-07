using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeX : MonoBehaviour
{
    public static float X = 25f;
    private void OnMouseOver()
    {
        X = gameObject.GetComponent<Slider>().value;
        if (Input.GetKey(KeyCode.Minus) || Input.GetKey(KeyCode.KeypadMinus))
        {
            gameObject.GetComponent<Slider>().value -= 1f;
        }
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            gameObject.GetComponent<Slider>().value += 1f;
        }
    }
}
