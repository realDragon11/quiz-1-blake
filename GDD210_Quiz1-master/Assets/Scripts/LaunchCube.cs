using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{


    public void OnMouseDown()
    {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
    }
}
