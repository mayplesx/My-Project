using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Star)
    {

        if(Star.tag == "MyStar")
        {
            ScoreNum += 1;
            Destroy(Star.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }

    }

}
