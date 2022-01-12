using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(-0.1f, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(0.1f, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.Translate(0.0f, 0.1f, 0.0f);

        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(0.0f, -0.1f, 0.0f);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            ps.Play();
        if (Input.GetKeyUp(KeyCode.Space))
            ps.Stop();
    }
}
