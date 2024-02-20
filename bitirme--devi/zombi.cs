using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombi : MonoBehaviour
{
    public float zombiHP = 100;
    bool zombiOlu;
    Animator zombiAnim;
    GameObject hedefOyuncu;
    public float kovalamaMesafesi;
    NavMeshAgent zombiNavMesh;
    public float saldirmaMesafesi;
    // Start is called before the first frame update
    void Start()
    {
        zombiAnim = this.GetComponent<Animator>();
        hedefOyuncu = GameObject.Find("Swat");
        zombiNavMesh = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (zombiHP < 0)
        {
            zombiOlu = true;
        }
        if (zombiOlu == true)
        {
            zombiAnim.SetBool("oldu", true);
            StartCoroutine(YokOl());
        }
        else
        {
            float mesafe = Vector3.Distance(this.transform.position, hedefOyuncu.transform.position);
            if (mesafe < kovalamaMesafesi)
            {
                zombiNavMesh.isStopped = false;
                zombiNavMesh.SetDestination(hedefOyuncu.transform.position);
                zombiAnim.SetBool("yuruyor", true);
                zombiAnim.SetBool("saldiriyor", false);
            }
            else
            {
                zombiNavMesh.isStopped = true;
                // durma animasyonu
                zombiAnim.SetBool("yuruyor", false);
                zombiAnim.SetBool("saldiriyor", false);
            }
            if (mesafe < saldirmaMesafesi)
            {
                zombiNavMesh.isStopped = true;
                zombiAnim.SetBool("yuruyor", false);
                zombiAnim.SetBool("saldiriyor", true);
            }
        }
    }
    IEnumerator YokOl()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
        
    }
     public void HasarAl()
    {
        zombiHP -= Random.Range(15, 25);
    }
}
