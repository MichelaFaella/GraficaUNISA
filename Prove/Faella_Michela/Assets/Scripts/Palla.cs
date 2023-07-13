using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palla : MonoBehaviour
{
    private GameController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Colonna"))
        {
            controller.PunteggioSottratto();
        }

        

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Traguardo"))
        {
            Debug.Log("wewe");
            controller.TraguardoRaggiunto();
        }
    }


}
