using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BOTOES : MonoBehaviour
{
    public void CarregarMENU()
    {
        SceneManager.LoadScene("MENU");
    }
    public void CarregarGAME()
    {//Chama no Onclick do botao de menu
        SceneManager.LoadScene("GAME");
    }

    public void CarregarGAMEOVER()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("GAMEOVER");
    }
}
