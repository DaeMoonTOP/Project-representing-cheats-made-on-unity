using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upper : MonoBehaviour
{
    [SerializeField] private Lower lower;

    private void OnMouseDown()
    {
        lower.Index--;
        if (lower.Index < 0)
        {
            lower.Index = 2;
        }
    }
}
