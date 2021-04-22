using UnityEngine;

public class Fall_Down : MonoBehaviour
{
    public static float fall_speed = 3f;

    void Update () {
        if (transform.position.y < -6f)
           Destroy(gameObject);
        transform.position -= new Vector3(0, fall_speed * Time.deltaTime, 0);
    }
}
