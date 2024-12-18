using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerObject : MonoBehaviour
{
    public GameObject sphere;
    public GameObject sphere1;
    public GameObject Cube;
    public GameObject Cylinder;
    public GameObject shpere2;

    private CubeSpeed moveCube;
    private MoveSphere moveSphere;
    private CubeSpeed moveSphere1;
    private CubeSpeed moveCylinder;
    private CubeSpeed moveshpere2;


    void Start()
    {
        moveCube = Cube.GetComponent<CubeSpeed>();
        moveSphere = sphere.GetComponent<MoveSphere>();
        moveSphere1 = sphere1.GetComponent<CubeSpeed>();
        moveCylinder = Cylinder.GetComponent<CubeSpeed>();
        moveshpere2 = shpere2.GetComponent<CubeSpeed>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            moveCube.Interact();
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveSphere.Interact();
        }
        if (Input.GetKey(KeyCode.E))
        {
            moveSphere1.Interact1();
        }
        if (Input.GetKey(KeyCode.R))
        {
            moveCylinder.Interact2();
        }
        if (Input.GetKey(KeyCode.T))
        {
            moveshpere2.Interact3();
        }
    }
}
