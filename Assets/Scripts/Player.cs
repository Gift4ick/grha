using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public float rotspeed = 100;
    public float jumpSpeed = 100;
    // 
    void Start()
    {

    }

    // 
    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // управление игрой по горизонтали Horizontal
        float movZ = Input.GetAxis("Vertical") * speed * Time.deltaTime; // управление игрой вертикально Vertical
        float rotY = Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime; // управоение игроком по диагонали
        float movY = 0;
        if (Input.GetButtonDown("Jump"))
        {
            movY = jumpSpeed * Time.deltaTime;
        }
        transform.Translate(movX, movY, movZ); // премещаем объект 
        transform.Rotate(0, rotY, 0); // поворачиваем объект 


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") // проверяем объект столкновения на 
         {
            Debug.Log("Ты умер");
            GetComponent<Renderer>().material.color = Color.blue; // получаем компомент у материала 
            Time.timeScale = 0; // останавливаем время в игре 
        }
    }
}

