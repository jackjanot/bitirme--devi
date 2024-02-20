using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atesetme : MonoBehaviour
{
    RaycastHit hit;
    public GameObject MermiCikisNoktasi;
    public bool AtesEdebilir;
    float GunTimer;
    public float TaramaHizi;
    public ParticleSystem MuzzleFlash;
    AudioSource SesKaynak;
    public AudioClip AtesSesi;
    public float Menzil;
    public float damageEnemy=20;
    
    RaycastHit Nesne;
    // Start is called before the first frame update
    void Start()
    {
        SesKaynak = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKey(KeyCode.Mouse0) && AtesEdebilir == true && Time.time > GunTimer)
        {
            Fire();
            GunTimer = Time.time + TaramaHizi;
           
        }
    }

    void Fire()
    {

        if (Physics.Raycast(MermiCikisNoktasi.transform.position, MermiCikisNoktasi.transform.forward, out hit, Menzil))
        {
            MuzzleFlash.Play();
            SesKaynak.Play();
            SesKaynak.clip = AtesSesi;
            Debug.Log(hit.transform.name);

            if (hit.transform.tag == "Enemy")
            {
                dusmanSagl�k enemyHealthScript = hit.transform.GetComponent<dusmanSagl�k>();
                enemyHealthScript.DeductHealth(damageEnemy);
            }
            else
            {
                Debug.Log("�skalad�n");
            }
        }
    }
    private void FixedUpdate()
    {
        if (Physics.Raycast(MermiCikisNoktasi.gameObject.transform.position, Camera.main.gameObject.transform.forward, out Nesne, 100f))
        {
            if (Nesne.transform.tag == "Enemy")
            {
                Destroy(Nesne.transform.gameObject);
            }
        }
    }

}
