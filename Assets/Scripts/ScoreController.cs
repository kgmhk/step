using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text score;
    private int nextStage = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print("score: "+ ScoreManager.instance.score);
        print("stage: "+ ScoreManager.instance.stage);
        score.text = "Score : " + ScoreManager.instance.score;
        // score.text = "Stage : " + ScoreManager.instance.stage;
        if (ScoreManager.instance.score == nextStage * ScoreManager.instance.stage) {
            ScoreManager.instance.stage++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
