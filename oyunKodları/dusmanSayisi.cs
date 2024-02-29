using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class dusmansayi : MonoBehaviour
{
    public Text enemyCountText; // UI Text elemaný
    private int enemyCount; // Düþman sayýsý

    private float enemycount;
    bool oyunDevam = true;
    bool oyunTamam = false;
    public Text durum;
    public Button btn;
    //public Image back;


    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("dusman").Length;  // Baþlangýçta düþman sayýsýný al
        UpdateEnemyCountText(); // Baþlangýçta düþman sayýsýný göster

    }

    void Update()
    {
        // Her güncellemede düþman sayýsýný kontrol etmek için gerekli deðil
        // Ancak baþka bir yerde düþmanlarýn dinamik olarak eklenip çýkarýldýðý durumlarda kullanýlabilir
        int currentEnemyCount = GameObject.FindGameObjectsWithTag("dusman").Length;
        if (currentEnemyCount != enemyCount)
        {
            enemyCount = currentEnemyCount;
            UpdateEnemyCountText(); // Düþman sayýsýný güncelle
            if (enemyCount <= 1)
            {
                oyunTamam = true;
                durum.text = "Tebrikler Kazandýnýz Sonraki Levele Geçmek Ýçin L ye Baýnýz";
                btn.gameObject.SetActive(true);
                Time.timeScale = 0f;

                //back.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.L))
                {
                    SceneManager.LoadScene(2);
                }
            }

        }

    }

    void UpdateEnemyCountText()
    {
        enemyCountText.text = "Düþman Sayýsý: " + enemyCount.ToString(); // UI Text elemanýnda düþman sayýsýný göster
    }

}

