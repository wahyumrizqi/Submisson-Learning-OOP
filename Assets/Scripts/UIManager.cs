using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public InputField txtPlayername;
    // Start is called before the first frame update
    public void GoToMain()
    {
        SetPlayernameToInstance();
        SceneManager.LoadScene("Main");
    }

    void SetPlayernameToInstance()
    {
        GameManager.instance.playerName = txtPlayername.text;
    }
}
