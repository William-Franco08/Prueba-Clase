using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Euler : MonoBehaviour
{
    public float speed = 60f;
    void Update()
    {
        float x = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Rotate(x, y, 0);
    }
}
