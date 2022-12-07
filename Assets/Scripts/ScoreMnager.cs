using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreMnager : MonoBehaviour
{
    private int LeftPlayerScore=0;
    private int RightPlayerScore=0;

    public Text LeftPlayerScoreText;
    public Text RightPlayerScoreText;

    public int FinalScore;

    public void LeftPlayerGoal()
    {
        LeftPlayerScore++;
        LeftPlayerScoreText.text = LeftPlayerScore.ToString();
        winner();

    }

    public void RightPlayerGoal()
    {
        RightPlayerScore++;
        RightPlayerScoreText.text = RightPlayerScore.ToString();
        winner();

    }

    private void winner()
    {
        if(LeftPlayerScore==FinalScore || RightPlayerScore == FinalScore)
        {
            SceneManager.LoadScene(2);
        }
    }

}
