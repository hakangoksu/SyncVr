using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCherry : MonoBehaviour
{
    public scrEventSystem objEvent;


    public AudioSource source;
    
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        objEvent = GameObject.FindGameObjectWithTag("Event").GetComponent<scrEventSystem>();
        source = GameObject.FindGameObjectWithTag("Fox").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (gameObject.transform.position.x < GameObject.FindGameObjectWithTag("Fox").transform.position.x)
        {

            Destroy(gameObject);
            objEvent.addScore();

            source.PlayOneShot(clip);
        }
    }
}
