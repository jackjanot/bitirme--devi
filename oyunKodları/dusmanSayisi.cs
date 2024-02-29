using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class dusmansayi : MonoBehaviour
{
    public Text enemyCountText; // UI Text eleman�
    private int enemyCount; // D��man say�s�

    private float enemycount;
    bool oyunDevam = true;
    bool oyunTamam = false;
    public Text durum;
    public Button btn;
    //public Image back;


    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("dusman").Length;  // Ba�lang��ta d��man say�s�n� al
        UpdateEnemyCountText(); // Ba�lang��ta d��man say�s�n� g�ster

    }

    void Update()
    {
        // Her g�ncellemede d��man say�s�n� kontrol etmek i�in gerekli de�il
        // Ancak ba�ka bir yerde d��manlar�n dinamik olarak eklenip ��kar�ld��� durumlarda kullan�labilir
        int currentEnemyCount = GameObject.FindGameObjectsWithTag("dusman").Length;
        if (currentEnemyCount != enemyCount)
        {
            enemyCount = currentEnemyCount;
            UpdateEnemyCountText(); // D��man say�s�n� g�ncelle
            if (enemyCount <= 1)
            {
                oyunTamam = true;
                durum.text = "Tebrikler Kazand�n�z Sonraki Levele Ge�mek ��in L ye Ba�n�z";
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
        enemyCountText.text = "D��man Say�s�: " + enemyCount.ToString(); // UI Text eleman�nda d��man say�s�n� g�ster
    }

}

