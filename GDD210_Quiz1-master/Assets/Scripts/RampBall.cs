using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RampBall : MonoBehaviour
{
	public Text PositionText;

    public void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(-Input.GetAxis("Horizontal")*20,0,0),ForceMode.Force) ;
    }

    public void OnTriggerEnter(Collider other)
    {
        PositionText.text = "CENTER";
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Left"))
        {
            PositionText.text = "LEFT";
        }
        else {
            if (collision.collider.tag.Equals("Right"))
            {
                PositionText.text = "RIGHT";
            }
        }
    }

}