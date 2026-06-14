using UnityEngine;

public class meat : MonoBehaviour
{
    private float deadZone = -10f;

    void Update()
    {

        Destroy(gameObject, 10f);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Meat collected!");
        }
    }
}
