using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PunctureArrow : MonoBehaviour
{
    private Rigidbody body;
    private Camera mainCamera;
    private Vector3 pointToRay;
    private RaycastHit raycastHit;
    private Vector3 mousVector;

    public float forceImpulse = 10f;
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        body = GetComponent<Rigidbody>();
    }
    private void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
          

            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit))
            {
                body.isKinematic = false;
                pointToRay = raycastHit.point;
            }
            mousVector = pointToRay - transform.position;

            transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z);
            body.velocity = mousVector.normalized * forceImpulse;

        }
        
    }
}
