using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndScene : MonoBehaviour
{
    [SerializeField] Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score : " + ScoreManager.instance.score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
