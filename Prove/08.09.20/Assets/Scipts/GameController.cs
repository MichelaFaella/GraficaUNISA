using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text t;
    private int cont;
    public GameObject cilindro;
    public GameObject cilindro2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneraCilindri());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(cilindro);
            Instantiate(cilindro2);
        }
    }

    public void ContaCilindri()
    {
        cont++;
        t.text = "Cilindri: " + cont;
    }


    private IEnumerator GeneraCilindri()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Instantiate(cilindro);
            Instantiate(cilindro2);
        }
    }
}
