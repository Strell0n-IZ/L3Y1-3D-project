using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollder : MonoBehaviour
{
    Vector3 lastPos;
    Quaternion lastRot;
    public GameObject vehicle;

    void Start()
    {
        lastPos = transform.position;
        lastRot = vehicle.transform.rotation;
    }

    void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.CompareTag("KillTrigger"))
        {
            transform.position = lastPos;
            vehicle.transform.rotation = lastRot;
        }
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            lastPos = transform.position;
            lastRot = other.transform.rotation;
        }
        
    }

}
