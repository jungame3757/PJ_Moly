using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD

=======
        rig = GetComponent<Rigidbody>();
>>>>>>> 8e96f87382e2739ab517d4f2032bbd2e37e050f7
    }

    void Update()
    {
<<<<<<< HEAD
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
=======
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(inputX, inputY, 0.0f);
        velocity *= speed;
        rig.velocity = velocity;
>>>>>>> 8e96f87382e2739ab517d4f2032bbd2e37e050f7
    }
}
