using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int winningScore = 10;
    public TMP_Text player1text;
    public TMP_Text player2text;
    public TMP_Text winMessage;

    private static int player1Score;
    private static int player2Score;
    
    public static bool playing;

    // Start is called before the first frame update
    void Start()
    {
        playing = true;
        winMessage.transform.parent.gameObject.SetActive(false);
        player1Score = 0;
        player2Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        player1text.text = player1Score.ToString();
        player2text.text = player2Score.ToString();

        if (player1Score >= winningScore)
        {
            winMessage.text = "PLAYER 1\nWINS!";
            winMessage.transform.parent.gameObject.SetActive(true);
        }
        else if (player2Score >= winningScore)
        {
            winMessage.text = "PLAYER 2\nWINS!";
            winMessage.transform.parent.gameObject.SetActive(true);
        }
    }

    public static void AddScore(int player)
    {
        if (player == 1)
        {
            player1Score++;
            if (player1Score == winningScore)
            {
                playing = false;
            }
        }
        else if (player == 2)
        {
            player2Score++;
            if (player2Score == winningScore)
            {
                playing = false;
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
