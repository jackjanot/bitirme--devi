using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
public class atesetme : MonoBehaviour
{

    RaycastHit hit;
    public GameObject MermiCikisNoktasi;
    public GameObject uzaklik;
    public bool AtesEdebilir;
    float GunTimer;
    public float TaramaHizi;
    public ParticleSystem MuzzleFlash;
    AudioSource SesKaynak;
    public AudioClip AtesSesi;
    public float Menzil;
    public float damageEnemy;
    Animator anim;
    public GameObject mermiefekti;
    public GameObject kanefekti;
    RaycastHit Nesne;
    karakterkontrol hpKontrol;
    public float mermi;
    public float sarjor;
    public float tasinanmermi;
    float eklenenmermi;
    float reloadTimer;
    public Text MermiSayac;
    public Text bilgi;
    public Text durum;




    // Start is called before the first frame update
    void Start()
    {
        SesKaynak = GetComponent<AudioSource>();
        hpKontrol = this.gameObject.GetComponent<karakterkontrol>();
        bilgi.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(uzaklik.transform.position, uzaklik.transform.forward, out hit, 4f))
            if (hit.transform.tag == "mermipaketi")
            {
                bilgi.enabled = true;
                bilgi.text = " MERMÝ PAKETÝ ALMAK ÝÇÝN E TUÞUNA BAS";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(hit.transform.gameObject);
                    tasinanmermi += 10f;
                }

            }
        MermiSayac.text = "" + mermi + "/" + tasinanmermi;
        eklenenmermi = sarjor - mermi;
        if (eklenenmermi > tasinanmermi)
        {
            eklenenmermi = tasinanmermi;
        }
        if (Input.GetKeyDown(KeyCode.R) && eklenenmermi > 0 && tasinanmermi > 0)

            if (Time.time > reloadTimer)
            {
                StartCoroutine(Reload());
                reloadTimer = Time.time;
                print("yükleme yapiliyor..");
            }


        if (Input.GetKey(KeyCode.Mouse0) && AtesEdebilir == true && Time.time > GunTimer && mermi > 0)
        {

            Fire();
            GunTimer = Time.time + TaramaHizi;
            if (hit.transform.tag == "dusman")
            {
                //enemyhealth enemyHealthScript = hit.transform.GetComponent<enemyhealth>();
                //enemyHealthScript.DeductHealth(damageEnemy);
                Instantiate(kanefekti, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.tag == "Untagged")
            {
                //enemyhealth enemyHealthScript = hit.transform.GetComponent<enemyhealth>();
                //enemyHealthScript.DeductHealth(damageEnemy);
                Instantiate(mermiefekti, hit.point, Quaternion.LookRotation(hit.normal));

            }

        }
    }


    void Fire()
    {
        if (mermi <= 0)
        {
            AtesEdebilir = false;
        }
        if (mermi > 0)
        {
            AtesEdebilir = true;
            mermi--;
        }
        if (tasinanmermi <= 0 && mermi <= 0)
        {
            durum.text = "Oyunu Kaybettiniz Tekrar Oynaynamak için Y tuþuna basýnýz";

        }
        if (Physics.Raycast(MermiCikisNoktasi.transform.position, MermiCikisNoktasi.transform.forward, out hit, Menzil))
        {
            MuzzleFlash.Play();
            SesKaynak.Play();
            SesKaynak.clip = AtesSesi;
            Debug.Log(hit.transform.name);
            if (hit.transform.tag == "dusman")
            {
                enemyhealth enemyHealthScript = hit.transform.GetComponent<enemyhealth>();
                enemyHealthScript.DeductHealth(damageEnemy);
            }
            else
            {
                Debug.Log("iskaladin");
            }
        }

    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1.2f);
        mermi = mermi + eklenenmermi;
        tasinanmermi = tasinanmermi - eklenenmermi;
    }









    /* private void FixedUpdate()
     {
         if (Physics.Raycast(MermiCikisNoktasi.gameObject.transform.position, Camera.main.gameObject.transform.forward, out Nesne, 100f))
         {
             if (Nesne.transform.tag == "dusman")
             {
                 //Destroy(Nesne.transform.gameObject);
                 anim.SetBool("oldu", true);

             }
         }
     }*/
}