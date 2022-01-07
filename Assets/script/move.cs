using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float time = Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
            rig.AddForce(Vector3.up * speed);
        if (Input.GetKey(KeyCode.S))
            rig.AddForce(Vector3.down * speed);
        if (Input.GetKey(KeyCode.A))
            rig.AddForce(Vector3.left * speed);
        if (Input.GetKey(KeyCode.D))
            rig.AddForce(Vector3.right * speed);
    }
}
