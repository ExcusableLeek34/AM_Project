using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject[] enemy;
    public Vector2 PValues;
    // public float Spawn;
    public float Wait;
    public float Minimo;
    public float Maximo;
    public int Starting;
    private int REnemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        Wait = Random.Range(Minimo, Maximo);    
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Starting);

        while (true)
        {
            REnemy = Random.Range(0, 3);

            Vector2 spawn = new Vector2(Random.Range(-PValues.x, PValues.x), Random.Range(-PValues.y, PValues.y));

            Instantiate (enemy[REnemy], spawn = transform.TransformPoint (0, Random.Range(0, 7), 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(Wait);
        }
    }
}
