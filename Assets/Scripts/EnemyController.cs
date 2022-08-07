using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;
    public float angle = 0; // угол 
    public float radius = 0.5f; // радиус
    public bool isCircle = false; // условие движения по кругу

    void Update()
    {
        if (isCircle)
        {
            angle += Time.deltaTime; // меняется плавно значение угла
            var x = Mathf.Cos(angle * speed) * radius;
            var y = Mathf.Sin(angle * speed) * radius;
            transform.position += new Vector3(x, 0, y);
        }
    }
}
