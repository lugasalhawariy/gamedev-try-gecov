using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{
    public float kecepatan, kekuatanLompat;
    public bool isGround;
    int jumlahLompat;

    // Start is called before the first frame update
    void Start()
    {
        jumlahLompat = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(jumlahLompat == 2){
            jumlahLompat = 0;
        }
    }

    // Jalan maju
    public void maju()
    {
        transform.Translate(Vector3.right * kecepatan * Time.fixedDeltaTime, Space.Self);
    }

    // Jalan mundur
    public void mundur()
    {
        transform.Translate(Vector3.left * kecepatan * Time.fixedDeltaTime, Space.Self);
    }

    // Lompat
    public void lompat()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, kekuatanLompat);
    }
}
