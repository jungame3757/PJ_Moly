using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    ParticleSystem part;
    Vector2 Mouse_pos;

     public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        part = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //(키보드 조작)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            part.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            part.Stop();
        }
        

        //(마우스 조작)
        Vector3 Mouse_pos = cam.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,-cam.transform.position.z + 13f)) - transform.position;
        float z = Mathf.Atan2(Mouse_pos.y, Mouse_pos.x)* Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,z);

        if (Input.GetMouseButtonDown(0))
        {
            part.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            part.Stop();
        }
    }
}
