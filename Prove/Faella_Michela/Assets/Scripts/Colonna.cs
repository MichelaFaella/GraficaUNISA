using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonna : MonoBehaviour
{
    public Transform piano;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= piano.position.y)
            Destroy(gameObject);
    }
}
