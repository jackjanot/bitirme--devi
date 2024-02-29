using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemyhealth : MonoBehaviour
{
    public float enemyHealth = 100f;
    private float enemycount = 8f;
    bool zombiOlu;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;
        if (enemyHealth <= 0)
        {
            zombiOlu = true;
            if (zombiOlu == true)
            {
                anim.SetBool("die", true);
            }
            enemyDead();

        }

        void enemyDead()
        {
            anim.SetBool("die", true);
            Destroy(gameObject, 2f);
        }

    }


}