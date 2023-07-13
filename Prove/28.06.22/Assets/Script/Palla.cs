using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palla : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private GameController gigi;
    public Transform piano;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gigi = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }


        if (transform.position.y < piano.position.y)
        {
            gigi.Sconfitta();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Traguardo"))
        {
            for (int i = 0; i < 2; i++)
                Instantiate(gameObject, new Vector3(4.47f, 12.2f, 0f), Quaternion.identity);
            gigi.Vittoria();
        }
        
    }


    
}
