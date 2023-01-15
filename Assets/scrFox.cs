using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrFox : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public scrEventSystem objEvent;
    // Start is called before the first frame update
    void Start()
    {
        objEvent = GameObject.FindGameObjectWithTag("Event").GetComponent<scrEventSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * 7;
        }
        if (gameObject.transform.position.x < -10 || gameObject.transform.position.y < -5) 
        {
            transform.position = new Vector2(transform.position.x -50, transform.position.y);
            objEvent.gameOver();
        }
    }
}
