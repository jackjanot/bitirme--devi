using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunBitis : MonoBehaviour
{
    public int dusmanSayisi = 9; // Ba�lang��ta 5 d��man var

    // Her d��man �ld�r�ld���nde �a�r�lacak metod
    public void DusmanOldur()
    {
        dusmanSayisi--; // D��man say�s�n� azalt
        if (dusmanSayisi <= 0)
        {
            OyunuBitir(); // D��man say�s� s�f�r veya daha az ise oyunu bitir
        }
    }

    // Oyunu bitiren metod
    void OyunuBitir()
    {
        Debug.Log("Tebrikler! Oyunu kazand�n�z.");
        // Oyunu istedi�iniz �ekilde bitirebilirsiniz, �rne�in oyunu durdurabilir veya men�ye ge�i� yapabilirsiniz.
    }
}
