using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text p1;
    public Text p2;
    private int punti1;
    private int punti2;


    // Start is called before the first frame update
    void Start()
    {
        punti1 = 10;
        punti2 = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void G1Buca() 
    {
        punti1 --;
        p1.text="Giocatore1: " + punti1;
    }

    public void G2Buca()
    {
        punti2 --;
        p2.text = "Giocatore2: " + punti2;
    }

    public void Esito1()
    {
        if (punti1 > punti2)
            p1.text = "Giocatore 1: WIN";

        if (punti1 < punti2)
            p1.text = "Giocatore 1: LOSE";
        else
            p1.text = "Giocatore 1: DRAW";
    }

    public void Esito2()
    {
        if (punti1 > punti2)
            p2.text = "WIN";

        if (punti1 < punti2)
            p2.text = "LOSE";
        else
            p2.text = "DRAW";
    }

}
