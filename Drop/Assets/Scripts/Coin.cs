using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public GameObject CoinObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(CoinObject);
            FindObjectOfType<Gems>().Count();
        }
    }

    void FixedUpdate()
    {
        transform.Rotate(1f, 1f, 1f * Time.deltaTime);
    }
}
