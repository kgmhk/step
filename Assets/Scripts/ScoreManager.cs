using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public int stage;
    // Start is called before the first frame update

    private void Awake() {
        instance = this;
    }
}
