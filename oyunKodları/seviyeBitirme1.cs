using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seviyeBitirme : MonoBehaviour
{
   public void seviye1bitir()
    {
        seviyeYönetici.seviye2 = true;
        SceneManager.LoadScene(0);
    }
    public void seviye2bitir()
    {
        
        SceneManager.LoadScene(0);
    }
}
