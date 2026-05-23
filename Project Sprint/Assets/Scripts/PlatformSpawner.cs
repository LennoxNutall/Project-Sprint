using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}