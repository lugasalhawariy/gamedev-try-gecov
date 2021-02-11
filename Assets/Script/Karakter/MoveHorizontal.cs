using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    public GameObject karakter;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDrag()
    {
        if (gameObject.name == "maju")
        {
            karakter.GetComponent<Chara>().maju();
        }
        else if (gameObject.name == "mundur")
        {
            karakter.GetComponent<Chara>().mundur();
        }

    }


}
