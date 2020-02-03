using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCangrejo : MonoBehaviour
{
    public GameObject Cangre;
    public GameObject angre1;
    public GameObject cangre2;
    int cangrecount;


    // Start is called before the first frame update
    void Start()
    {
        cangrecount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cangrecount == 0)
        {
            Cangre.SetActive(true);
            angre1.SetActive(false);
            cangre2.SetActive(false);

        }
        if (cangrecount == 1)
        {
            Cangre.SetActive(false);
            angre1.SetActive(true);
            cangre2.SetActive(false);

        }
        if (cangrecount == 2)
        {
            Cangre.SetActive(false);
            angre1.SetActive(false);
            cangre2.SetActive(true);

        }
    }
    public void Cangre1()
    {
        cangrecount = 0;
    }
    public void Cangre2()
    {
        cangrecount = 1;
    }
    public void Cangre3()
    {
        cangrecount = 2;
    }
}
