using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    private GameController gigi;
    public Transform piano;

    // Start is called before the first frame update
    void Start()
    {
        gigi = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(piano.position.y > gameObject.transform.position.y)
        {
            gigi.Strike();
        }
    }

    
}
