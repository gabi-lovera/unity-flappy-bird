using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    


    public Rigidbody2D cuerpo;
    public float velocidad;
    public float altura;
    public GameObject rectArriba;
    public GameObject rectAbajo;
    public float tiempo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
       
            ConstruirNivel();
    }

    public void ConstruirNivel()
    {
            Instantiate(rectArriba, new Vector3(10, 7), transform.rotation);
            Instantiate(rectAbajo, new Vector3(10, -7), transform.rotation);
            Instantiate(rectArriba, new Vector3(17, 6), transform.rotation);
            Instantiate(rectAbajo, new Vector3(17, -9), transform.rotation);
            Instantiate(rectArriba, new Vector3(24, 6), transform.rotation);
            Instantiate(rectAbajo, new Vector3(24, -7), transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {

        tiempo += Time.deltaTime;
        cuerpo.velocity = new Vector2(velocidad, cuerpo.velocity.y);
        if(Input.GetMouseButtonDown(0))
        {
            cuerpo.velocity = new Vector2(cuerpo.velocity.x, altura);
        }
        if(tiempo<100)
        { 
        if(transform.position.y>7|| transform.position.y<-7)
        {
            Reinicio();
        }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }


    }


    public void Reinicio()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
