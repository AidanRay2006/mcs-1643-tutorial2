using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int winningScore;
    public TMP_Text player1text;
    public TMP_Text player2text;

    private static int player1Score;
    private static int player2Score;

    // Start is called before the first frame update
    void Start()
    {
        player1Score = 0;
        player2Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        player1text.text = player1Score.ToString();
        player2text.text = player2Score.ToString();
    }

    public static void AddScore(int player)
    {
        if (player == 1)
        {
            player1Score++;
        }
        else if (player == 2)
        {
            player2Score++;
        }
    }
}
