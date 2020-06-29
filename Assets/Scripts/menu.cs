using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Button toro, toro2;

    public void Toro()
    {
        SceneManager.LoadScene(1);
    }

    public void Toro2()
    {
        SceneManager.LoadScene(2);
    }

    public void exit()
    {
        Application.Quit();
    }
}
