using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private float speed = 2f;
    int curWaypointIndex = 0;
    // Update is called once per frame
    private void Update()
    {
        print("oo " + ScoreManager.instance.score);
        // if (ScoreManager.instance.score > 0) {
        //     speed += ScoreManager.instance.score * 0.01f;
        // }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[curWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
