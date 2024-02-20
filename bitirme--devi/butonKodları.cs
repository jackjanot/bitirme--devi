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
    public void Sanayibolge()
    {
        SceneManager.LoadScene("sanayi bolgesi alani");
    }
   public void OrmanlikAlan()
    {
        SceneManager.LoadScene("ormanlik alan");
    }
    public void OyunHakkında()
    {
        SceneManager.LoadScene("oyun hakkinda");
    }
}
    

