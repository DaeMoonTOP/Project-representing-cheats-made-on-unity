using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lower : MonoBehaviour
{
    public int Index = 2;

    private void OnMouseDown()
    {
        Index++;
        if (Index > 2)
        {
            Index = 0;
        }
    }
}
