using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlChar : MonoBehaviour
{
    public GameObject scriptChara;

    // Start is called before the first frame update

    public void karakterMaju()
    {
        scriptChara.GetComponent<Chara>().maju();
    }

    public void karakterMundur()
    {
        scriptChara.GetComponent<Chara>().mundur();
    }

    public void karakterLompat()
    {
        scriptChara.GetComponent<Chara>().lompat();
        jumlahLompat++;
    }
}
