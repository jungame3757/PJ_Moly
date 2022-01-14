using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_V2 : MonoBehaviour
{
    public GameObject bullet;
    public Transform pos;
    public float cooltime;
    float currtime;
    // Start is called before the first frame update
    void Start()
    {
        currtime = cooltime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currtime <= 0f)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, pos.position, pos.rotation);
            }
            currtime = cooltime;
        }
        currtime -= Time.deltaTime;
    }
}
