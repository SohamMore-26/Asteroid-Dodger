using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningAsteroidSpawn : MonoBehaviour
{

    public GameObject BurningAsteroid;
    public float BigspawnRate = 5;
    private float BigspawnTime = 0;

    private GameObject x;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BigspawnTime < BigspawnRate)
        {
            BigspawnTime = BigspawnTime + Time.deltaTime;
        }
        else
        {
            x = Instantiate(
                BurningAsteroid,
                new Vector3(
                Random.Range(-11f, 11f),
                transform.position.y,
                transform.position.z),
                transform.rotation
            );
            BigspawnTime = 0;
        }

        Destroy(x, 10f);




    }
}
