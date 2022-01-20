using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    bool Is_Die;
    private float Max_Hp = 100;
    private float Current_Hp;

    // 람다식 추가
    
    // Start is called before the first frame update
    void Start()
    {
        Current_Hp = Max_Hp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamages(float Damages)
    {
        Current_Hp -= Damages;

        if (Current_Hp <= 0)
        {
            Is_Die = true;
        }
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        TakeDamages(5);
    }
}
