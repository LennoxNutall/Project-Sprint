using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{

    public GameObject platform;
    public float platformLength = 20f;
   
   private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("TriggerPlatform"))
        {
            Vector3 spawnPos = new Vector3(0, 10, transform.position.z - platformLength);
            Instantiate(platform, spawnPos, Quaternion.identity);
        }
    }
}