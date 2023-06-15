using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWithCar : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform cartransform;
    float offset;
    void Start()
    {
        offset =cartransform.position.z- this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(this.transform.position.x, this.transform.position.y, cartransform.position.z - offset);
    }
}
