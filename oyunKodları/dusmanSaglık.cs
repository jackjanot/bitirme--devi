using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusmanSaglık : MonoBehaviour
{
    public float enemyhealth = 100f;
    public float enemycount = 2f;
    private Animator anim;
    bool zombiOlu;
    public void DeductHealth(float deduchealth)
    {
        void Start()
        {
            anim = GetComponent<Animator>();

        }

        enemyhealth -= deduchealth;
        if (enemyhealth <= 0)
        {
            //EnemyDead();
            zombiOlu = true;
            if (zombiOlu == true)
            {
                anim.SetBool("oldu", true);
            }
            else
            {
                anim.SetBool("oldu", true);
            }
        }

    }
    IEnumerator YokOl()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);

    }


}

