using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jaula : MonoBehaviour
{
    private Jugador Jugador;
    void Start()
    {
        Jugador = FindObjectOfType<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Jugador.Reinicio();  
    }
}
