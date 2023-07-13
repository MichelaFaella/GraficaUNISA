using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContaRimbalzi : MonoBehaviour
{

    private GameController gigi;

    // Start is called before the first frame update
    void Start()
    {
        gigi = GameObject.FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Box"))
            gigi.ContaRimbalzi();
            
    }
}
