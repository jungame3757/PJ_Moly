using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    Transform player_tr;
    Vector3 Mouse_pos;
    // Start is called before the first frame update
    void Start()
    {
        player_tr = GameObject.Find("player").transform;
        Mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,-Camera.main.transform.position.z + 13f)) - player_tr.position;
        Invoke("destroy_bullet",2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Mouse_pos.normalized * speed * Time.deltaTime);
    }
    void destroy_bullet()
    {
        Destroy(gameObject);
    }
}
