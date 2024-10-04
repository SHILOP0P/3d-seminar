using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere1 : MonoBehaviour
{
    static public int y;
    static public int z;
    static public int c;
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;
    public GameObject Plane4;
    public GameObject Plane5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionExit(Collision collision)
    {
        z = Random.Range(0, 255);
        y = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)z, (byte)y, (byte)c, 1);
    }
    public void OnCollisionEnter(Collision collision)
    {
        VRTest.x++;
        z = Random.Range(0, 255);
        y = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)z, (byte)y, (byte)c, 1);
    }
}
