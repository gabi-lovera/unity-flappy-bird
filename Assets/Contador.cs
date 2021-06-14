using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public TextMesh contador;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        contador.text = "" + tiempo.ToString("f0");

        if (contador.text=="100")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }
}
