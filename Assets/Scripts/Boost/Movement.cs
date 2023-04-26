using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust =100f;
    [SerializeField] float rotationThrust =1f;
    Rigidbody rb;
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ProcessThrust();
        ProccessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProccessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            AplyRotation(rotationThrust);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            AplyRotation(-rotationThrust);
        }
    }
    private void AplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation =  false;
    }
}
