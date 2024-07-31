using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float prevValue = -105.10f;
    public void Enact(float verticalMovement)
    {
        transform.Rotate(new Vector3(verticalMovement - prevValue, 0, 0));
        prevValue = verticalMovement;
    }
}
