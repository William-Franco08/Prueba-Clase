using UnityEngine;

public class QRotation : MonoBehaviour
{
    public float speed = 60f;
    void Update()
    {
        float x = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Quaternion rotx = Quaternion.AngleAxis(x * Time.deltaTime, Vector3.right);
        Quaternion roty = Quaternion.AngleAxis(y * Time.deltaTime, Vector3.up);

        transform.Rotate(x, y, 0);
    }
}
