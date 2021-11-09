using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI highScoreText;
    public int scoreValue;
    public int highScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        highScoreText = GameObject.Find("highScoreText").GetComponent<TextMeshProUGUI>();
        highScoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
       //scoreValue += 5;
        scoreText.text = "Score: " + scoreValue.ToString();
        if(scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            highScoreText.text = "High Score: " + highScoreValue.ToString();
        }
    }
}
