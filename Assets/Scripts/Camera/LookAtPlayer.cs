using UnityEngine;
using System.Collections;

/* make object look at player   */

public class LookAtPlayer : MonoBehaviour
{
    Vector3 cameraDirection;

    void Update()
    {
        cameraDirection = Camera.main.transform.forward;
        cameraDirection.y = 0;
        transform.rotation = Quaternion.LookRotation(cameraDirection);
    }
}