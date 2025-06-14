using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    public int scoreCount = 0;
    public void UpdateUI()
    {
        scoreCount += 10;
        scoreText.text = "Score: "+scoreCount;
    }
}
