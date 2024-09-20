using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_t : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) direction = Vector2.up;
        if (Input.GetKey(KeyCode.DownArrow)) direction = Vector2.down;
        if (Input.GetKey(KeyCode.LeftArrow)) direction = Vector2.left;
        if (Input.GetKey(KeyCode.RightArrow)) direction = Vector2.right;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
