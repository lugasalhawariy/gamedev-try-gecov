using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maju : MonoBehaviour
{
    public GameObject karakter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, speed, 0);
    }

}
