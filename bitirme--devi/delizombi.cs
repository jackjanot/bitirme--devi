using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class deliZombi : MonoBehaviour
{
    CharacterController karakter;
    public Transform hedef;
    NavMeshAgent Agent;
    public float mesafe;
    private void Update()
    {
        mesafe = Vector3.Distance(transform.position, hedef.position);
        Agent.destination = hedef.position;
        if (mesafe <= 10)
        {
            Agent.enabled = true;
        }
        else
        {
            Agent.enabled = false;
        }
    }
}
