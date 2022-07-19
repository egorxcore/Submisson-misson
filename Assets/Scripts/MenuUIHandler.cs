using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public static MenuUIHandler Instance;
    public Text nameText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        NameController.PlayerName = nameText.text;
        SceneManager.LoadScene(1);
    }


    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit(); // original code to quit Unity player
#endif
    }
}
