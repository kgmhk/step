using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject opstacles;
    [SerializeField] GameObject waypoint;
    private float currentTimeToSpawn;
    private float opstacleHeight = 1.5f;
    private float startingPoint = 5f;
    private int blockCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(opstacles, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        currentTimeToSpawn = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeToSpawn > 0) {
            currentTimeToSpawn -= Time.deltaTime;
        } else {
            SpawnObject();
            currentTimeToSpawn = 2f;
        }
    }

    private void SpawnObject() {
        // Vector3 v = new Vector3()
        // Instantiate(waypoint, new Vector3(transform.position.x, transform.position.y + opstacleHeight, transform.position.z), transform.rotation);
        var block = Instantiate(opstacles, new Vector3(transform.position.x, transform.position.y + opstacleHeight, transform.position.z), transform.rotation);
        // block.tag = "block" + blockCount++;

        opstacleHeight += 1.6f;
    }
}
