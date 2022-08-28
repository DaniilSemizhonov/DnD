using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{
    public void Up()
    {
        transform.position += Vector3.back * 1.0f;
    }
    public void Right()
    {
        transform.position += Vector3.left * 1.0f;
    }
    public void Left()
    {
        transform.position += Vector3.right * 1.0f;
    }
    public void Down()
    {
        transform.position += Vector3.forward * 1.0f;
    }
}