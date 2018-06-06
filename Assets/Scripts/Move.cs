using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
    {
    public float speed = 0.3f;
    public float distance = 8;
	void Start ()
    {
        Debug.Log(speed); //
        //transform.Translate(1, 0, 0); //сторона отправки объекта
	}
	
	void Update ()
    {
        if (transform.position.x >= distance || transform.position.x <= -distance)

        {
            speed = -speed;
        }
     
        
        
        transform.Translate(speed, 0, 0);
	}
}
