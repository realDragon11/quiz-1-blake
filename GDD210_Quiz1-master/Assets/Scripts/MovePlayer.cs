using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Z)) {
        this.GetComponent<Rigidbody>().MovePosition(new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z-.1f)); }
    }
}
