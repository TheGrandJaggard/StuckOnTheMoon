using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    
    void OnStartCrouching()
    {
        transform.Rotate(180, 0, 0);
    }

    void OnStopCrouching()
    {
        transform.Rotate(-180, 0, 0);
    }
}
