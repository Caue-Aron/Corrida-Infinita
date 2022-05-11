using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIInicial : MonoBehaviour
{
    public void sair(){
        Application.Quit();
        Debug.Log("Sair");
    }

    public void OnJogarClick(){
        SceneManager.LoadScene("jogo");
    }

    public void creditos(){
        SceneManager.LoadScene("creditos");
    }

    public void menu(){
        SceneManager.LoadScene("menu");
    }
}
