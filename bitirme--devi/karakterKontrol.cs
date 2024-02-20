using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterKontrol : MonoBehaviour
{
    Animator anim;
    [SerializeField]
    private float karakterHiz;
    
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
   

    // Update is called once per frame
    void Update()
    {
        Hareket();
    }
    void Hareket()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        anim.SetFloat("Horizontal", yatay);
        anim.SetFloat("Vertical", dikey);
        this.gameObject.transform.Translate(yatay * karakterHiz * Time.deltaTime, 0, dikey * karakterHiz*Time.deltaTime);



    }
}
