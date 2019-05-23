using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().EndGame();
            Destroy(other.gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.Rotate(1f, 1f, 1f * Time.deltaTime);
    }
}
