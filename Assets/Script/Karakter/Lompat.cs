using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lompat : MonoBehaviour
{
    public GameObject karakter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Handle screen touches.
        if (Input.GetButton("tombol lompat"))
        {
            karakter.GetComponent<Chara>().lompat();
        }
    }


}
