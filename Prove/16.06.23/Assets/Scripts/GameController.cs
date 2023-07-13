using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text t, score;
    private bool vittoria;
    private int cont;

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
        if(!vittoria)
            t.text = "GAME OVER";
    }

    public void Vittoria()
    {
        t.text = "WIN";
        vittoria = true;
        score.text= "Final Score: " + cont;
    }

    public void Score()
    {
        cont++;
        score.text = "Score: "+cont;
    }
}
