using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player"){
            anim.SetBool("Aberto", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag=="Player"){
            anim.SetBool("Aberto", false);
        }
    }
}
