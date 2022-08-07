using System;
using UnityEngine;
using UnityEngine.UEGraphics;
using UnityEngine.UI;

public class ESP : MonoBehaviour
{
    private GameObject[] vrags;
    public Camera player_camera;
    private Vector3 place_line = new Vector3(Screen.width / 2, Screen.height);
    public Material material;
    public TMPro.TextMeshProUGUI PMText;

    public bool Boxes = false;
    public bool Traces = false;
    public bool Distances = false;

    [SerializeField] private AimSize As;
    [SerializeField] private AimDistance ad;
    [SerializeField] private Lower lower;

    private void Start()
    {
        UEGraphics.Drawing.SetMaterial(material);
    }

    private void FixedUpdate()
    {
        if (lower.Index == 0)
        {
            PMText.text = "Upper";
            place_line = TracesSettings.Upper;
        }
        if (lower.Index == 1)
        {
            PMText.text = "Midlle";
            place_line = TracesSettings.Midlle;
        }
        if (lower.Index == 2)
        {
            PMText.text = "Lower";
            place_line = TracesSettings.Lower;
        }
    }

    public void OnGUI()
    {
        UEGraphics.Drawing.DrawLine(new Vector3((Screen.width / 2) - As.aim_size.value, Screen.height / 2), new Vector3((Screen.width / 2) - ad.aim_sistance.value, Screen.height / 2), MyColor.Green); // Left line
        UEGraphics.Drawing.DrawLine(new Vector3((Screen.width / 2) + As.aim_size.value, Screen.height / 2), new Vector3((Screen.width / 2) + ad.aim_sistance.value, Screen.height / 2), MyColor.Green); // Right line
        UEGraphics.Drawing.DrawLine(new Vector3(Screen.width / 2, (Screen.height / 2) - As.aim_size.value), new Vector3(Screen.width / 2, (Screen.height / 2) - ad.aim_sistance.value), MyColor.Green); // Top line
        UEGraphics.Drawing.DrawLine(new Vector3(Screen.width / 2, (Screen.height / 2) + As.aim_size.value), new Vector3(Screen.width / 2, (Screen.height / 2) + ad.aim_sistance.value), MyColor.Green); // Bottom line

        vrags = GameObject.FindGameObjectsWithTag("vrag");
        foreach (var pos in vrags)
        {
            Vector3 pos2 = player_camera.WorldToScreenPoint(pos.transform.position);
            Vector3 position = default;
            if (pos2.z > 0f)
            {
                position = GUIUtility.ScreenToGUIPoint(pos2);
                position.y = (float)Screen.height - position.y;
                if (Boxes)
                {
                    UEGraphics.Drawing.DrawBox(position, new Vector3(SizeX.X, SizeY.Y, 0f), MyColor.Green);
                }
                if (Traces)
                {
                    UEGraphics.Drawing.DrawLine(place_line, new Vector3(position.x, position.y + 50f), MyColor.Green);
                }
                if (Distances)
                {
                    UEGraphics.Drawing.DrawLabel(position.x - 10f, position.y - 75f, 100, 100, Convert.ToString(Convert.ToInt32(Vector3.Distance(transform.position, pos.transform.position))));
                }
            }
        }
    }
}

public struct MyColor
{
    public static Color Green = new Color(0, 255f, 0f, 255f); // green
    public static Color Red = new Color(255f, 0f, 0f, 255f); // red
    public static Color Blue = new Color(0f, 0f, 255f, 255f); // Blue
}


public struct TracesSettings
{
    public static Vector3 Upper = new Vector3(Screen.width / 2, 0);
    public static Vector3 Midlle = new Vector3(Screen.width / 2, Screen.height / 2);
    public static Vector3 Lower = new Vector3(Screen.width / 2, Screen.height);
}
