using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Task : MonoBehaviour
{
    [SerializeField] GameObject taskbutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Task_NPC")
        {
            Time.timeScale = 0f;
            taskbutton.SetActive(true);
        }
    }

    public void Task()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Task");
    }

}