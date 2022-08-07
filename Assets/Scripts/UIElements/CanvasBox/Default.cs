using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Default : MonoBehaviour
{
    public GameObject SliderX;
    public GameObject SliderY;

    private void OnMouseDown()
    {
        SliderX.GetComponent<Slider>().value = 25f;
        SliderY.GetComponent<Slider>().value = 50f;
    }
}
