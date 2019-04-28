using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float Speed = 0f;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * Speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 3.48)
        {
            //this.gameObject.SetActive (false);
            Destroy(this.gameObject);
        }
    }
}