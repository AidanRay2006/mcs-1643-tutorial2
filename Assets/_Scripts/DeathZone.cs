using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform startPos;
    public GameObject ballPrefab;
    public int opposingPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Ball"))
        {
            //Debug.Log($"{other.transform.name} hust entered {transform.name}");

            //set other player's score up by 1
            GameManager.AddScore(opposingPlayer);

            //destroy the ball
            Destroy(other.gameObject);

            //create a new ball in the center
            Instantiate(ballPrefab, startPos.position, Quaternion.identity);
        }
    }
}
