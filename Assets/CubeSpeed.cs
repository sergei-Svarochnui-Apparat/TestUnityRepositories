using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpeed : MonoBehaviour
{
    public int MoveSpeed;
    public void Update()
    {
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    transform.position += new Vector3(0f, 0f, 0.1f) * MoveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0f, 0f, -0.1f) * MoveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //    transform.position += new Vector3(-0.5f, 0f, 0f) * MoveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.R))
        //{
        //    transform.position += new Vector3(0.5f, 0f, 0f) * MoveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.T))
        //{
        //    transform.position += new Vector3(0.5f, 0f, 0f) * MoveSpeed * Time.deltaTime;
        //}
    }

    private void Awake()
    {
        
    }
    public virtual void Interact()
    {
        transform.position += new Vector3(0f, 0f, 0.1f) * MoveSpeed * Time.deltaTime;
    }
    public virtual void Interact1()
    {
        transform.position += new Vector3(0f, 0.1f, 0f) * MoveSpeed * Time.deltaTime;
    }
    public virtual void Interact2()
    {
        transform.position += new Vector3(-0.1f, 0f, 0f) * MoveSpeed * Time.deltaTime;
    }
    public virtual void Interact3()
    {
        transform.position += new Vector3(0f, -0.2f, 0f) * MoveSpeed * Time.deltaTime;
    }
}
