using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Move1 : MonoBehaviour
{
    //public GameObject other;

    public Rigidbody rb;
    public float speed = 20f;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collider"))
        {
            //Debug.Log("ded");
            FindObjectOfType<GameManager>().EndGame();
            Destroy(other.gameObject);
        }
    }
    void FixedUpdate()
    {

        float moveAD = CrossPlatformInputManager.GetAxis("Horizontal");
        //float INPUTV = CrossPlatformInputManager.GetAxis("Vertical");
        //Vector3 virtoal = new Vector3(INPUTH * speed, 0, INPUTV * speed);
        //rb.AddForce(virtoal);
        //float moveWS = Input.GetAxis("Vertical");
        //float moveAD = Input.GetAxis("Horizontal");
        Vector3 movee = new Vector3(moveAD * speed, 0, 0);
        rb.AddForce(movee);
        
    }
}
