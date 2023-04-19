using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gem_control : MonoBehaviour
{

    //[SerializeField] AudioSource audio;
    [SerializeField] GameObject controller;
    [SerializeField] Text t;
    ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
            scoreKeeper = controller.GetComponent<ScoreKeeper>();
        }
        //if (audio == null)
            //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("player hit");
        scoreKeeper.AddPoints(10);
        t.text = "Score " + scoreKeeper.GetScore();
        //AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        //audio.play(); -- this is simpler but won't work if coin gets destroyed before clip plays
        Destroy(gameObject);
        //Destroy(gameObject, 1); //takes an optional second parameter for number of seconds before the destroying
    }

}
