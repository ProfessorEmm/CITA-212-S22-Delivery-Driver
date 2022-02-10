using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Both the position of the car and camera should be the same
    
    [SerializeField] GameObject goThingToFollow;
    void Update()
    {
        transform.position = goThingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
