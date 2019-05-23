using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("ded");
            FindObjectOfType<GameManager>().EndGame();
            Destroy(other.gameObject);
        }
    }
}
