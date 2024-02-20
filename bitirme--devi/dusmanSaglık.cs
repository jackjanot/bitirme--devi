using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dusmanSaglık : MonoBehaviour
{
    public float enemyhealth = 100f;
    public float enemycount = 0.5f;
    private Animator anim;
    public void DeductHealth(float deduchealth)
    {
        enemyhealth -= deduchealth;
        if (enemyhealth <= 0)
        {
            EnemyDead();
        }
        void EnemyDead()
        {
            Destroy(gameObject);

        }
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void DusmanOl()
    {
        anim.SetBool("oldu", true);
        Destroy(gameObject, 10f);

    }
    
}
