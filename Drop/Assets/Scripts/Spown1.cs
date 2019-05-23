using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown1 : MonoBehaviour
{

    public GameObject Object;
    public GameObject Object1;
    public GameObject Coin;
    public GameObject Cube;
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
        StartCoroutine(waitspowner());
    }

    void Update()
    {

        spownwait = Random.Range(spownleastwait, spownMustwait);
    }
    IEnumerator waitspowner()
    {
        yield return new WaitForSeconds(startwait);
        while (!stop)
        {
            int randenemy = Random.Range(1, 15);
            transform.position = spown.position + Setting;

            Vector3 spownPosition = new Vector3(Random.Range(-spownValues.x, spownValues.x), 0, Random.Range(-spownValues.z, spownValues.z));
            switch (randenemy)
            {
                case 1:
                case 2:
                case 3:
                    Instantiate(Object, transform.position + spownPosition, Quaternion.identity);
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    Instantiate(Object1, transform.position + spownPosition, Quaternion.identity);
                    break;
                case 9:
                case 10:
                case 11:
                    Instantiate(Coin, transform.position + spownPosition, Quaternion.identity);
                    break;
                case 12:
                case 13:
                case 14:
                    Instantiate(Cube, transform.position + spownPosition, Quaternion.identity);
                    break;
            }


            //Instantiate(enemies, transform.position + spownPosition, Quaternion.identity);
            // Instantiate(enemies[randenemy], spownPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spownwait);

        }

    }

}
