using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	public float Speed = 5f;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * Speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x >= 3.5) {
			//this.gameObject.SetActive (false);
			Destroy (this.gameObject);
		}
	}

    private void OnTriggerEnter2D(Collider2D hit)
    {
        Destroy(this.gameObject);
    }
}
