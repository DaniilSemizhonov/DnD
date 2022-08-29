using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class MoveControler : MonoBehaviour
{
    public int moves;
    public GameObject kek;
    public GameObject Buttons;
    public float speed = 1;
    public int dndspeed;
    [SerializeField] InputField field;
    string input_text;
    
    public void Up()
    {
        transform.position += Vector3.back * speed;
        moves++;
    }
    public void Right()
    {
        transform.position += Vector3.left * speed;
        moves++;
    }
    public void Left()
    {
        transform.position += Vector3.right * speed;
        moves++;
    }
    public void Down()
    {
        transform.position += Vector3.forward * speed;
        moves++;
    }

    private void Update()
    {
        input_text = field.text;
        int.TryParse(input_text, out dndspeed);
        if (moves >= dndspeed)
        {
            moves = 0;
            kek.SetActive(true);
            Buttons.SetActive(false);
        }
    }
}