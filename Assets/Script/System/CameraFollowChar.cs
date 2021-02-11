using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowChar : MonoBehaviour
{
    public GameObject Chara;
    public float jarak;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(Chara.transform.localPosition.x + (Chara.transform.localScale.x*jarak), 0, -10f);
        transform.localPosition = Vector3.Slerp(transform.localPosition, pos, 0.1f);
    }
}


