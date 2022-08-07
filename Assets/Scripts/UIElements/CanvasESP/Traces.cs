using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Traces : MonoBehaviour
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
        esp.Traces = !esp.Traces;
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
