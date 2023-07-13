using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text t;
    private bool vittoria;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Vittoria() 
    {
        t.text = "WIN";
        vittoria = true;
    }


    public void Sconfitta()
    {
        if (vittoria)
            return;

        t.text = "GAME OVER";
    }
}
