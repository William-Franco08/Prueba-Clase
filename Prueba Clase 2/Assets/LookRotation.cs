using UnityEngine;

public class LookRotation : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            speed * Time.deltaTime
        );
    }
}
