using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{
    public int moves;
    public GameObject kek;
    public GameObject Buttons;
    public void Up()
    {
        transform.position += Vector3.back * 1.0f;
        moves++;
    }
    public void Right()
    {
        transform.position += Vector3.left * 1.0f;
        moves++;
    }
    public void Left()
    {
        transform.position += Vector3.right * 1.0f;
        moves++;
    }
    public void Down()
    {
        transform.position += Vector3.forward * 1.0f;
        moves++;
    }

    private void Update()
    {
        if (moves >= 5)
        {
            moves = 0;
            kek.SetActive(true);
            Buttons.SetActive(false);
        }
    }
}