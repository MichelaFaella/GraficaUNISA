using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindro : MonoBehaviour
{
    public GameController gigi;

    // Start is called before the first frame update
    void Start()
    {
        gigi = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Vasca"))
        {
            Destroy(gameObject);
            gigi.ContaCilindri();
        }
    }
}
