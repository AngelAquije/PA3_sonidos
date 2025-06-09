using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public float radio = 5f;
    public float velocidad = 1f;
    private float angulo = 0f;

    void Update()
    {
        angulo += velocidad * Time.deltaTime;


        float x = Mathf.Cos(angulo) * radio;
        float z = Mathf.Sin(angulo) * radio;

        transform.position = new Vector3(x, transform.position.y, z);
    }
}
