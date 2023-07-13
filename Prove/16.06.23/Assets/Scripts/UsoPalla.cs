using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsoPalla : MonoBehaviour
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
        if (gameObject.transform.position.y < piano.position.y)
            gigi.Sconfitta();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Traguardo"))
        {
            gigi.Vittoria();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Piano"))
        {
            gigi.Score();
            gameObject.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }


}
