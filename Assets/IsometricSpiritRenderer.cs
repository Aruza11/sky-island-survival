using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class IsometricSpiritRenderer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().sortingOrder = (int)(transform.position.y * -10);
    }
}
