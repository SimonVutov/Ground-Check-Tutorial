using UnityEngine;

public class GroundCheckOnCollisionEnter : MonoBehaviour
{
    public bool grounded = false;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded) //jump code
        {
            GetComponent<Rigidbody>().AddForce(transform.up * 3, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}
