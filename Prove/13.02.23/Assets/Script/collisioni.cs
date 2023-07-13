using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioni : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Buca") && CompareTag("G1"))
        {
            gigi.G1Buca();
            Destroy(other.gameObject);
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        if (other.CompareTag("Buca") && CompareTag("G2"))
        {
            gigi.G2Buca();
            Destroy(other.gameObject);
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        if (other.CompareTag("Traguardo") && CompareTag("G1"))
        {
            gigi.Esito1();
        }

        if (other.CompareTag("Traguardo") && CompareTag("G2"))
        {
            gigi.Esito2();
        }
    }
}
