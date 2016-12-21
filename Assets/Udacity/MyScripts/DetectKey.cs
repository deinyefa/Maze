using UnityEngine;
using System.Collections;

public class DetectKey : MonoBehaviour {

    public Key keyObject;

    void FixedUpdate ()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10))
        {
            if (keyObject != null)
            {
                keyObject.KeyAnimation();
                Debug.Log("should be animating key!");
            }
        }
    }
}
