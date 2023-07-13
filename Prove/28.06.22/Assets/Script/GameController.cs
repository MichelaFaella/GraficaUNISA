using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text t;
    private bool win, lose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Vittoria() {
        if (win|| lose)
            return;

        t.text="WIN";
        win = true;
    }

    public void Sconfitta() {
        if (lose || win)
            return;

        t.text = "GAME OVER";
        lose = true;
    }
}
