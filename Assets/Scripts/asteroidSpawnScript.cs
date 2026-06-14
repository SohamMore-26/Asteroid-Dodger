using UnityEngine;

public class asteroidSpawnScript : MonoBehaviour
{

    public GameObject asteroid;
    public float spawnRate = 5;
    private float spawnTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTime < spawnRate)
        {
            spawnTime = spawnTime + Time.deltaTime;
        }
        else
        {
            Instantiate(
                asteroid,
                new Vector3(
                Random.Range(-11f, 11f),
                transform.position.y,
                transform.position.z ),
                transform.rotation
            );
            spawnTime = 0;
        }
    }
}
