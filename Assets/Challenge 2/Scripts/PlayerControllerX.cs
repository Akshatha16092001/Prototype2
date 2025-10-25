using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //added code
            Vector3 spawnPos = new Vector3(transform.position.x, 0, transform.position.z);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
