using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIMain : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txtPlayerName;
    void Start()
    {
        txtPlayerName.text = "Welcome: " + GameManager.instance.playerName;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("title-screen");
    }
}
