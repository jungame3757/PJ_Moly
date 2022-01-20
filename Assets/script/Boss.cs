using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public GameObject text;
    public Material material;
    public string Boss_name;
    public float Hp;
    int phase;
    void Start()
    {
        material.SetColor("_Color",Color.white);
        material.SetFloat("_Height", 0.5f);
        phase = 0;
    }
    void Update()
    {
        if(Hp <= 50.0f && phase == 0)
        {
            StartCoroutine("NextPhase");
            phase++;
        }
        if(Hp <= 0f)
            Dead();
    }
    
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Hit");
        Hp -= 0.5f;
    }
    IEnumerator Hit()
    {
        material.SetFloat("_RimPower", 15.0f);
        yield return new WaitForSeconds(0.05f);
        material.SetFloat("_RimPower", 20.0f);
    }
    IEnumerator NextPhase()
    {
        Color curr_color = material.GetColor("_Color");
        Color new_color = new Color(0.6f,0.6f,0.6f,1.0f);
        float time = 0.0f;
        while(time <= 0.5f)
        {
            material.SetFloat("_Height", Mathf.Lerp(0.5f,0.8f,time * 2));
            material.SetColor("_Color",Color.Lerp(curr_color,new_color,time * 2));
            time += Time.deltaTime;
            yield return null;
        }
    }
    void Dead()
    {
        material.SetFloat("_RimPower", 20.0f);
        text.GetComponent<Text>().text = "Win!";
        text.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = false;
        Destroy(this);
    }
}
