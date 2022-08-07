using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Boxes : MonoBehaviour
{
    [SerializeField] private ESP esp;
    private bool color = false;
    public TextMeshProUGUI text;

    private void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void OnMouseDown()
    {
        esp.Boxes = !esp.Boxes;
        color = !color;
        if (color)
        {
            text.color = Color.green;
        }
        else
        {
            text.color = Color.red;
        }
    }
}
