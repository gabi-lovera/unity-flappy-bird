using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    public Rigidbody2D cuerpo;
    public float velocidad;

    // Use this for initialization
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        cuerpo.velocity = new Vector2(velocidad, cuerpo.velocity.y);

    }

 
}
