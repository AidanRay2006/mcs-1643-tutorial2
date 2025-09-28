using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 1.0f;
    public AudioClip bounceSound;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        rb = GetComponent<Rigidbody>();

        float angle = Random.value * 50 - 25;

        if (Random.value < 0.5f)
        {
            angle += 180;
        }

        transform.eulerAngles += new Vector3(0, angle, 0);


        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.CompareTag("Floor"))
        {
            AudioSource.PlayClipAtPoint(bounceSound, transform.position, 1f);
        }
    }
}
