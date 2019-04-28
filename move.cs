using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour
{
    float dirx, diry;
    //private float diry;
    [Range(1f, 20f)]
    private float moveSpeed = 6f;
    CircleCollider2D Coli;
    //private Rigidbody2D rb;
    


    /* Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }
    */

    // Update is called once per frame
    void Update()
    {
        dirx = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        diry = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + dirx, transform.position.y + diry);
       

       //  rb.velocity = new Vector2(dirx, 0f);
      //  rb.velocity = new Vector2(diry, 0f);
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        Destroy(this.gameObject);
    }
}
