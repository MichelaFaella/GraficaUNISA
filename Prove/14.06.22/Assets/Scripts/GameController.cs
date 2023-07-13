using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text t;
    private int cont;
    private bool sconfitta, colore;
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sconfitta() 
    {
        t.text = "GAME OVER";
        sconfitta = true;
    }

    public void Vittoria()
    {
        cont++;

        if (cont >= 3 && !sconfitta)
        {
            t.text = "WIN";
        }
    }

    public void CambiaColore() 
    {
        if (!colore)
        {
            cubo.GetComponent<Renderer>().material.color = new Color(0.18f, 0.21f, 0.25f);
            colore = true;
        }
        else 
        {
            cubo.GetComponent<Renderer>().material.color = new Color(0.6f, 0.32f, 0.28f);
            colore = false;
        }
    }
}
