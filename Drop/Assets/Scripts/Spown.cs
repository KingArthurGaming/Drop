using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour
{

    public GameObject Object;
    public GameObject Object1;
    public GameObject Coin;
    public Vector3 spownValues;
    public float spownwait;
    public float spownMustwait;
    public float spownleastwait;
    public float startwait;
    public bool stop;
    public Transform spown;
    public Vector3 Setting;
    //float XY = 0f;


    void Start()
    {
        StartCoroutine(Waitspowner());
    }

    void Update()
    {

        spownwait = Random.Range(spownleastwait, spownMustwait);
    }
    IEnumerator Waitspowner()
    {
        yield return new WaitForSeconds(startwait);
        while (!stop)
        {
            int randenemy = Random.Range(1, 12);
            transform.position = spown.position + Setting;

            Vector3 spownPosition = new Vector3(Random.Range(-spownValues.x, spownValues.x), 0, Random.Range(-spownValues.z, spownValues.z));
            switch (randenemy)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Instantiate(Object, transform.position + spownPosition, Quaternion.identity);
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Instantiate(Object1, transform.position + spownPosition, Quaternion.identity);
                    break;
                case 10:
                case 11:
                    Instantiate(Coin, transform.position + spownPosition, Quaternion.identity);
                    break;
            }


            //Instantiate(enemies, transform.position + spownPosition, Quaternion.identity);
            // Instantiate(enemies[randenemy], spownPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spownwait);

        }

    }

}
