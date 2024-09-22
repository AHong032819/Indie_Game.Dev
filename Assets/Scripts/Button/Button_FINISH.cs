using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_FINISH : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject FINISHButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "FINISH")
        {
            Time.timeScale = 0f;
            FINISHButton.SetActive(true);
        }
    }
    public void FINISH()
    {
        SceneManager.LoadScene("Test_Scene2");
    }
}
