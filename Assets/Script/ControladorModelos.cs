using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorModelos : MonoBehaviour
{
    public GameObject Woody;
    public GameObject Robot;
    public GameObject Cangrejo;
    public GameObject Nave;
    public GameObject Pistola;
    public int Modelo;
    public GameObject CanvasWoody;
    public GameObject CanvasCangre;
    // Start is called before the first frame update
    void Start()
    {
        Modelo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Modelo == 0)
        {
            Woody.SetActive(false);
            Robot.SetActive(false);
            Cangrejo.SetActive(false);
            Nave.SetActive(false);
            Pistola.SetActive(false);
            CanvasWoody.SetActive(false);
            CanvasCangre.SetActive(false);
        }
        if (Modelo == 1)
        {
            Woody.SetActive(true);
            Robot.SetActive(false);
            Cangrejo.SetActive(false);
            Nave.SetActive(false);
            Pistola.SetActive(false);
            CanvasWoody.SetActive(true);
            CanvasCangre.SetActive(false);
        }
        if (Modelo == 2)
        {
            Robot.SetActive(true);
            Woody.SetActive(false);
            Cangrejo.SetActive(false);
            Nave.SetActive(false);
            Pistola.SetActive(false);
            CanvasWoody.SetActive(false);
            CanvasCangre.SetActive(false);
        }
        if (Modelo == 3)
        {
            Cangrejo.SetActive(true);
            Woody.SetActive(false);
            Robot.SetActive(false);
            Nave.SetActive(false);
            Pistola.SetActive(false);
            CanvasWoody.SetActive(false);
            CanvasCangre.SetActive(true);
        }
        if (Modelo == 4)
        {
            Nave.SetActive(true);
            Woody.SetActive(false);
            Robot.SetActive(false);
            Cangrejo.SetActive(false);
            CanvasWoody.SetActive(false);
            Pistola.SetActive(false);
            CanvasCangre.SetActive(false);
        }
        if (Modelo == 5)
        {
            Pistola.SetActive(true);
            Woody.SetActive(false);
            Robot.SetActive(false);
            Cangrejo.SetActive(false);
            Nave.SetActive(false);
            CanvasWoody.SetActive(false);
            CanvasCangre.SetActive(false);
        }
    }
    public void ApWoody()
    {
        Modelo =1;
    }
    public void ApRobot()
    {
        Modelo = 2;
    }
    public void ApCangrejo()
    {
        Modelo = 3;
    }
    public void ApNave()
    {
        Modelo = 4;
    }
    public void ApPistola()
    {
        Modelo = 5;
    }
}
