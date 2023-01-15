using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mountain;
    public float spawnRate = 2;
    private float timer = 0;

    void Start()
    {
        spawnMountain();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) 
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnMountain();
            timer = 0;
        }
        
    }
    void spawnMountain()
    {
        Instantiate(mountain, new Vector3(transform.position.x, Random.Range(-2, +1), 1), transform.rotation);
    }
}
