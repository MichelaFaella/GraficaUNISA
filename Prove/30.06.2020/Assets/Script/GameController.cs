using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int cont = 5;
    public Text t;
    public GameObject strike;

    // Start is called before the first frame update
    void Start()
    {
        t.text = "Blocchi in piedi: " + cont;
        strike.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cado()
    {
        cont--;
        t.text = "Blocchi in piedi: " + cont;
    }

    public void Strike()
    {
        strike.SetActive(true);
    }
}
