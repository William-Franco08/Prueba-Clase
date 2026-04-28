using UnityEngine;

public class Slerp : MonoBehaviour
{
    public Transform target;
    public float orbitSpeed = 10f;
    public float selfRotationSpeed = 50f;

    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);
    }
}