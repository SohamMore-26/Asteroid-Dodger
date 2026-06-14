using UnityEngine;

public class asteroid : MonoBehaviour
{
    private float deadZone = -10f;

    void Update()
    {
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
    }
}