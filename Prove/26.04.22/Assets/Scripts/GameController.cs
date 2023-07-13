using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int cont;
    public GameObject moneta;
    private int punteggio;
    public Text t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GeneraMonete()
    {
        for (int i = 0; i < cont; i++)
        {
            Instantiate(moneta, new Vector3(Random.Range(-2.5f, 2.5f), 10f, Random.Range(-2.5f,2.5f)), Quaternion.identity);
        }
    }

    public void ContaMonete() 
    {
        punteggio++;
        t.text = "Score: " + punteggio;
    }

    public void ResetAttivato()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
