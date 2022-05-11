using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeater : MonoBehaviour
{
    public float offset = 19f;
    public Transform cameraTransform;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x + offset < cameraTransform.position.x)
        {
            Vector3 newPos = cameraTransform.position;
            newPos.x += 2 * offset;
            transform.position = new Vector3(newPos.x, transform.position.y, transform.position.z);
        }
    }
}
