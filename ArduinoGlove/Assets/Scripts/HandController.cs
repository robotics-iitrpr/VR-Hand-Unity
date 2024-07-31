using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    [SerializeField]
    private float prevValue = -105.10f;
    public void Enact(float verticalMovement)
    {
        transform.Rotate(new Vector3(0, verticalMovement - prevValue, 0));
        prevValue = verticalMovement;
    }
}
