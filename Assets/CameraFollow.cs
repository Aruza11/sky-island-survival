using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; //Higher value, faster camera locks onto target, needs to be between 0 and 1
    public Vector3 offset;

    void LateUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
