using UnityEngine;

public class meat : MonoBehaviour
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
