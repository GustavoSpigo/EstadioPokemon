using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar : MonoBehaviour
{
    public Rigidbody rigi;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player"){
            rigi.useGravity = true;
        }
    }
}
