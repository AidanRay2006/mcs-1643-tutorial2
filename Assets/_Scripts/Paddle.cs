using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 12.0f;
    public KeyCode upKey;
    public KeyCode downKey;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(downKey))
        {
            transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }
        {
            
        }
    }
}
