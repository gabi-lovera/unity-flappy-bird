using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectArriba : MonoBehaviour
{

    private Jugador Jugador;

    void Start()
    {
        Jugador = FindObjectOfType<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Jugador.transform.position.x - transform.position.x > 12)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (Jugador.tiempo < 100)
        {
            Jugador.Reinicio();

        }
        
    }
}
