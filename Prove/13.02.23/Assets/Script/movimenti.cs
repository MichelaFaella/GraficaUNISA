using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimenti : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public KeyCode sopra;
    public KeyCode sotto;
    public KeyCode destra;
    public KeyCode sinistra;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(sopra))
        {
            rb.AddForce(Vector3.forward * speed*Time.deltaTime);
        }

        if (Input.GetKey(sotto))
        {
            rb.AddForce(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(sinistra))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(destra))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }
    }
}
