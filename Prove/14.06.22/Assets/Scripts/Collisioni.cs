using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisioni : MonoBehaviour
{
    private GameController gigi;

    // Start is called before the first frame update
    void Start()
    {
        gigi = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rosso"))
        {
            Debug.Log("Rosso");
            gigi.Sconfitta();
        }

        if (other.CompareTag("Grigio")&& other.gameObject.GetComponent<Renderer>().material.color!=Color.green) {
            Debug.Log("Grigio");
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
            gigi.Vittoria();
        }
    }


}
