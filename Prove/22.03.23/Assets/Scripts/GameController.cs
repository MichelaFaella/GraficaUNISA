using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject uno, due, tre;
    private int cont;
    public GameObject palla;
    public Text t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerdoVita()
    {
        if (cont == 0)
        {
            cont++;
            uno.SetActive(false);
            Instantiate<GameObject>(palla);
            return;
        }

        if (cont == 1)
        {
            cont++;
            due.SetActive(false);
            Instantiate<GameObject>(palla);
            return;
        }

        if (cont == 2)
        {
            cont++;
            tre.SetActive(false);
            t.text = "GAME OVER";
            return;
        }

    }

    public void ResetAttivato()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
