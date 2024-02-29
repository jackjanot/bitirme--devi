using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kullaniciArayuzu : MonoBehaviour
{
    public Text zaman, durum;
    public float zamanSayaci = 300;
    public GameObject sahteMenü;
    bool oyunDurdu;

    bool oyunDevam = true;
    private float saglik = 100f;
    bool oyunTamam = false;
    public Button btn;



    // public Text mermiText;
    //public Text saglikText;
    //GameObject oyuncu;

    // Start is called before the first frame update
    void Start()
    {
        //oyuncu = GameObject.Find("asker");
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";

        }
        else if (!oyunDevam)
        {
            durum.text = "Oyunu Kaybettiniz Tekrar Oynayýn";
            btn.gameObject.SetActive(true);
        }
        //zamanSayaci -= Time.deltaTime;
        // zaman.text = (int)zamanSayaci + "";
        if (zamanSayaci <= 0)
        {
            oyunDevam = false;

        }
        //mermiText.text=oyuncu.GetComponent<atesetme>().GetSarjor().ToString()+ "/" + oyuncu.GetComponent<atesetme>().GetCephane().ToString();
        //saglikText.text = "HP=" + oyuncu.GetComponent<karakterkontrol>().GetSaglik();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (oyunDurdu == true)
            {
                OyunuDevamEttir();
            }
            else if (oyunDurdu == false)
            {
                OyunuDurdur();
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            OyundanCikis();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            LevelDegisimi();
        }

    }
    public void OyunuDurdur()
    {
        sahteMenü.SetActive(true);
        Time.timeScale = 0;
        oyunDurdu = true;
    }
    public void OyunuDevamEttir()
    {
        sahteMenü.SetActive(false);
        Time.timeScale = 1;
        oyunDurdu = false;
    }
    public void OyundanCikis()
    {
        SceneManager.LoadScene("Oyuna Giris");
    }
    public void LevelDegisimi()
    {
        SceneManager.LoadScene(2);
    }
    /* private void OnCoolisionEnter(Collision other)
     {

         if (saglik < 0)
         {
             saglik -= Random.Range(10, 20);
             saglikText.text = "HP=" + oyuncu.GetComponent<karakterkontrol>();

         }
     }*/


}
