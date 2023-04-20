using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
     [SerializeField] private GameObject objectToFollow = null;
     [SerializeField] private Vector3 offset = new Vector3(0, 1, -5);

    // NOTE: FixedUpdate should be used for all updates related to rigid bodies or the physics engine.
    private void FixedUpdate() {
        transform.position = objectToFollow.transform.position + offset;
    }
}
