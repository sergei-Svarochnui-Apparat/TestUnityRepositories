using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : CubeSpeed
{

    private void Start()
    {
        MoveSpeed = 25;
    }
    public override void Interact()
    {
        transform.position += new Vector3(1f,0,0) * MoveSpeed * Time.deltaTime;
    }
    // Update is called once per frame
    //public override void Interact()
    //{
    //    transform.position += new Vector3(1f,0f,0f) * MoveSpeed;
    //}
}
