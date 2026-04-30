using UnityEngine;

public class MovementQ : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;
    public Animator anima;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Movimineto
        Vector3 forwardMovement = transform.forward * verticalInput * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + forwardMovement);

        //rotacion
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;

        Quaternion deltaRotation =Quaternion.AngleAxis(rotationAmount, Vector3.up);
        
        rb.MoveRotation(rb.rotation * deltaRotation);

        //animacion
        float walkVal = Mathf.Abs(verticalInput);
        anima.SetFloat("Walk", walkVal);
    }
    void Update()
    {
        
    }
}
