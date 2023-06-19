using UnityEngine;

public class BykeController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D wheelR;
    [SerializeField] private Rigidbody2D Byke;
    [SerializeField] private float speed;
    [SerializeField] private float torque;

    private float moveInput;

    private void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        wheelR.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
        Byke.AddTorque(-moveInput * -torque * Time.fixedDeltaTime);
    }
}
