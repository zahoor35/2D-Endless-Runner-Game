using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float miny;
    public float timebetweenspawn;
    private float spawntime;

    void Update()
    {
        if (Time.time > spawntime)
        {
            spawn();
            spawntime = Time.time + timebetweenspawn;
        }

    }

    void spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(miny, maxY);


        Instantiate(obstacle,transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

}
