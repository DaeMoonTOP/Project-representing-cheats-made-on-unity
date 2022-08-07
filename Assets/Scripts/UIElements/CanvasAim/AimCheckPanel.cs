using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UEGraphics;

public class AimCheckPanel : MonoBehaviour
{
    [SerializeField] private AimSize As;
    [SerializeField] private AimDistance ad;

    private void OnPostRender()
    {
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f - As.aim_size.value, 3.8f, 2.6f), new Vector3(6.1f - ad.aim_sistance.value, 3.8f, 2.6f), Color.black); // Left line
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f + As.aim_size.value, 3.8f, 2.6f), new Vector3(6.1f + ad.aim_sistance.value, 3.8f, 2.6f), Color.black); // Right line
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f, 3.8f - As.aim_size.value, 2.6f), new Vector3(6.1f, 3.8f - ad.aim_sistance.value, 2.6f), Color.black); // Top line
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f, 3.8f + As.aim_size.value, 2.6f), new Vector3(6.1f, 3.8f + ad.aim_sistance.value, 2.6f), Color.black); // Bottom line
    }

    private void OnDrawGizmos()
    {
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f - As.aim_size.value, 3.8f, 2.6f), new Vector3(6.1f - ad.aim_sistance.value, 3.8f, 2.6f), Color.black); // Left line
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f + As.aim_size.value, 3.8f, 2.6f), new Vector3(6.1f + ad.aim_sistance.value, 3.8f, 2.6f), Color.black); // Right line
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f, 3.8f - As.aim_size.value, 2.6f), new Vector3(6.1f, 3.8f - ad.aim_sistance.value, 2.6f), Color.black); // Top line
        UEGraphics.Drawing.DrawLine(new Vector3(6.1f, 3.8f + As.aim_size.value, 2.6f), new Vector3(6.1f, 3.8f + ad.aim_sistance.value, 2.6f), Color.black); // Bottom line
    }
}
