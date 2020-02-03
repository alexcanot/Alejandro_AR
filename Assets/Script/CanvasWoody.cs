using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasWoody : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Woody;
    public Animator WoodyAnimator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Bailes1()
    {
        WoodyAnimator.SetBool("Baile1", true);
        WoodyAnimator.SetBool("Baile2", false);
        WoodyAnimator.SetBool("Baile3", false);
        WoodyAnimator.SetBool("Baile4", false);
    }
    public void Bailes2()
    {
        WoodyAnimator.SetBool("Baile1", false);
        WoodyAnimator.SetBool("Baile2", true);
        WoodyAnimator.SetBool("Baile3", false);
        WoodyAnimator.SetBool("Baile4", false);
    }
    public void Bailes3()
    {
        WoodyAnimator.SetBool("Baile1", false);
        WoodyAnimator.SetBool("Baile2", false);
        WoodyAnimator.SetBool("Baile3", true);
        WoodyAnimator.SetBool("Baile4", false);
    }
    public void Bailes4()
    {
        WoodyAnimator.SetBool("Baile1", false);
        WoodyAnimator.SetBool("Baile2", false);
        WoodyAnimator.SetBool("Baile3", false);
        WoodyAnimator.SetBool("Baile4", true);
    }
}
