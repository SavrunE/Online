using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouth : MonoBehaviour
{
    private Transform checker;
    private Camera mainCamera;
    private RaycastHit raycastHit;
    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        checker = transform;
    }
    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out raycastHit))
        {
            Vector3 pointToRay = raycastHit.point;
        }
    }
}
