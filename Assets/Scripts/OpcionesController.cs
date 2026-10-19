using System;
using UnityEngine;

public class OpcionesController : MonoBehaviour
{

    [SerializeField] RectTransform panelMenu;


    public void MostrarOpciones()
    {
        panelMenu.gameObject.SetActive(true);
    }

    public void QuitarOpciones()
    {
        panelMenu.gameObject.SetActive(false);
    }


    public void AplicarEspañol()
    {
       
    }
    public void AplicarIngles()
    {

    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
