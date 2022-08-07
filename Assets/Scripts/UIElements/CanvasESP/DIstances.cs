using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DIstances : MonoBehaviour
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
        esp.Distances = !esp.Distances;
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
