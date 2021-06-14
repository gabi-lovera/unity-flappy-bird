using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectAbajo : MonoBehaviour
{
    
    private Jugador Jugador;
    public GameObject recArriba;

    void Start()
    {
        Jugador = FindObjectOfType<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Jugador.transform.position.x - transform.position.x > 12)
        {
            float yRandom = Random.Range(-4, 4);
            float randomEspacio = Random.Range(0,3);

            Instantiate(gameObject, new Vector2(Jugador.transform.position.x + 10, -6 + yRandom), transform.rotation);
            Instantiate(recArriba, new Vector2(Jugador.transform.position.x + 10, 6 + yRandom+randomEspacio), transform.rotation);

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
