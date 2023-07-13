using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int cont = 0;
    public Text punteggio;
    private GameObject[] pareti;
     
    // Start is called before the first frame update
    void Start()
    {
        pareti = GameObject.FindGameObjectsWithTag("Box");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContaRimbalzi() 
    {
        cont++;
        punteggio.text = "Rimbalzi: " + cont;

        Color c = new Color(Random.value, Random.value, Random.value);


        if (cont % 10 == 0)
        {

            for (int i = 0; i < pareti.Length; i++)
            {
                var material = pareti[i].GetComponent<Renderer>().material;
                c.a = material.color.a;
                material.color = c;
            }
        }

    }

    public void ResetAttivato() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
