using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject taskbutton;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Test_Scene1");
    }
}
