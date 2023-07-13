using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text t;
    private int cont = 3;
    private bool vittoria;
    public GameObject palla;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TraguardoRaggiunto()
    {
        t.text = "Final Score: " + cont;
        vittoria = true;
        palla.SetActive(false);
    }

    public void PunteggioSottratto()
    {
        if (!vittoria)
        {
            cont--;
            t.text = "Score: " + cont;
        }
    
    }

    public void ResetAttivato()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
