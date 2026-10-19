using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

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
        CambiarIdioma("es");
    }

    public void AplicarIngles()
    {
        CambiarIdioma("en");
    }

    private void CambiarIdioma(string codigoIdioma) // metodo que permite cambiar de idioma, para despues aplicarlo a los botones
    {
        Locale locale = LocalizationSettings.AvailableLocales.GetLocale(codigoIdioma); // lo que hace es que busca si existe este idioma, si lo encuentra lo guarda en la variable

        if (locale != null) // si ha encontrado algun idioma
        {
            LocalizationSettings.SelectedLocale = locale; //esto lo que hace es aplicar el idioma
        }
        else
        {
            Debug.LogWarning("No se ha encontrado el idioma: " + codigoIdioma);
        }
    }

}
