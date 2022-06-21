using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejoEscena : MonoBehaviour
{
    public void LoadScene(string NombreEscena)
    {
        SceneManager.LoadScene(NombreEscena);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
