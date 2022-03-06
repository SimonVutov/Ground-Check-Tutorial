using UnityEngine;

public class GroundCheckRaycast : MonoBehaviour
{
    public bool grounded = false;
    public float groundCheckDistance;
    private float bufferCheckDistance = 0.1f; //slightly above 0

    void Update()
    {
        groundCheckDistance = (GetComponent<CapsuleCollider>().height / 2) + bufferCheckDistance;

        if (Input.GetKeyDown(KeyCode.Space) && grounded) //jump code
        {
            GetComponent<Rigidbody>().AddForce(transform.up * 3, ForceMode.Impulse);
        }

        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, groundCheckDistance))
        { //ray hit ground
            grounded = true;
        } else
        { //ray did not hit ground
            grounded = false;
        }
    }
}
