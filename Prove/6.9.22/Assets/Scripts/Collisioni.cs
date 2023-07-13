using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisioni : MonoBehaviour
{
    private GameController gigi;
    public Transform traguardo;
    private GameObject[] legno;
    private GameObject[] vetro;

    // Start is called before the first frame update
    void Start()
    {
        gigi = FindObjectOfType<GameController>();
        legno = GameObject.FindGameObjectsWithTag("Legno");
        vetro = GameObject.FindGameObjectsWithTag("Vetro");

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < traguardo.position.y)
            gigi.Sconfitta();

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            var materiale = vetro[0].gameObject.GetComponent<Renderer>().material;
            var materiale2 = legno[0].gameObject.GetComponent<Renderer>().material;

            for (int i = 0; i < vetro.Length; i++)
            {
                vetro[i].gameObject.GetComponent<Renderer>().material = materiale2;
            }

            for (int j = 0; j < legno.Length; j++)
            {
                legno[j].gameObject.GetComponent<Renderer>().material = materiale;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Traguardo"))
            gigi.Vittoria();

        if (collision.collider.CompareTag("Vetro"))
        {
            var colore = collision.gameObject.GetComponent<Renderer>().material.color.a;
            collision.gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, colore);
        }
            
    }

}
