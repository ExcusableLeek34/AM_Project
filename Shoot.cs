using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Transform arrowing;
	public GameObject Arrow;
	private GameManager GM;
	private float timeR = 0f;
    private float timem = 0f;



    // Update is called once per frame
    void Update () {
		timeR += Time.deltaTime;
        timem += Time.deltaTime;
        if (timeR >= 3.5f) {
			Shooting();
			timeR = 0f; 
		} else {

		}

        if (this.timem >= 18f)
        {
            //this.gameObject.SetActive (false);
            Destroy(this.gameObject);
        }

        /* this.transform.position = new Vector3 (transform.position.x, transform.position.y, -1);
		if (this.transform.position.y >= 14) {
			this.gameObject.SetActive (false);

			//pooler.DestroyThis (this.gameObject);
		}if (timeR >= 5f){
			GM.EndGame();
			timeR = 0f;
		}
		if (GM.curGamestate == GameManager.GameState.GAMEOVER) {
			this.transform.position = new Vector3 (transform.position.x, 15, transform.position.z );
		}*/
    }
	void Shooting(){
		Instantiate (Arrow, arrowing.position, arrowing.rotation);
	}


}
