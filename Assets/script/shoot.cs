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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("play");
            part.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("play");
            part.Stop();
        }
        Mouse_pos = Input.mousePosition;
        Mouse_pos = cam.WorldToScreenPoint(Mouse_pos);
        Mouse_pos.x -= transform.position.x;
        Mouse_pos.y -= transform.position.y;
        Debug.Log(part.shape.rotation.z);
        Debug.Log(Mathf.Atan2(Mouse_pos.y, Mouse_pos.x) * Mathf.Rad2Deg);
        part.shape.rotation.Set(0.0f, 0.0f, Mathf.Atan2(Mouse_pos.y, Mouse_pos.x) * Mathf.Rad2Deg);
    }
}
