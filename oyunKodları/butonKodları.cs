using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonKodları : MonoBehaviour
{
    public void CikisButonu()
    {
        Application.Quit();
    }
    public void EndustriBolge()
    {
        SceneManager.LoadScene("endüstriyel bolge");
    }
    public void EndustriyelBolge2()
    {
        SceneManager.LoadScene("endüstriyel bolge Level1");
    }
    public void OyunHakkında()
    {
        SceneManager.LoadScene("oyun hakkinda");
    }
    public void OyunGiris()
    {
        SceneManager.LoadScene("Oyuna Giris");
    }
}


