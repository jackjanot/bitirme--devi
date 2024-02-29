using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.AI;

public class delizombi : MonoBehaviour
{
    Animator anim;

    public Transform hedef;
    NavMeshAgent agent;
    public float mesafe;
    public float saldiriMesafesi;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("hýz", agent.velocity.magnitude);
        mesafe = Vector3.Distance(transform.position, hedef.position);
        agent.destination = hedef.position;
        if (mesafe <= 10)
        {

            agent.enabled = true;





        }
        else
        {
            agent.enabled = false;



        }
        if (mesafe < saldiriMesafesi)
        {



            anim.SetBool("attack", true);
            //anim.SetBool("yurume", true);

        }
        else
        {

            anim.SetBool("attack", false);
            //anim.SetBool("yurume", false);
        }

    }
    public void HasarVer()
    {
        hedef.GetComponent<karakterkontrol>().HasarAl();
    }
}