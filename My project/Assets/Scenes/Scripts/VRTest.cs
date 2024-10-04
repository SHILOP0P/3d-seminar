using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRTest : MonoBehaviour
{
    public GameObject Test;
    static public int x = 0;
    public Text Mytxt;
    public int z;
    public int y;
    public int c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Mytxt.text = x.ToString();
    }
    public void OnClickBut()
    {
        z = Random.Range(0, 255);
        y = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)z, (byte)y, (byte)c, 1);
    }
}
