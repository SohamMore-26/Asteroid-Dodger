using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatSpawn : MonoBehaviour
{
    public GameObject meat;
    public float meatspawnRate = 8;
    private float meatspawnTime = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (meatspawnTime < meatspawnRate)
        {
            meatspawnTime = meatspawnTime + Time.deltaTime;
        }
        else
        {
            Instantiate(
                meat,
                new Vector3(
                Random.Range(-11f, 11f),
                transform.position.y,
                transform.position.z),
                transform.rotation
            );
            meatspawnTime = 0;
        }
    }
}
