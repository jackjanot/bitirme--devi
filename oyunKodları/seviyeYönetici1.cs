using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class seviyeYönetici : MonoBehaviour
{
    public Button seviye1_button, seviye2_button;


    public static bool seviye1, seviye2;
    private void Start()
    {
        seviye1 = true;
        
    }
    private void Update()
    {
        if (seviye2 == true)
        {
            seviye2_button.interactable = true;
           
        }
    }

}
