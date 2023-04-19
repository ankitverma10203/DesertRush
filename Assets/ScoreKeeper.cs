using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] Text Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("score: " + score);
    }


    public int GetScore()
    {
        return score;
    }
}
