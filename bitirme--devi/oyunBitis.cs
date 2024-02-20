using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunBitis : MonoBehaviour
{
    public int dusmanSayisi = 9; // Baþlangýçta 5 düþman var

    // Her düþman öldürüldüðünde çaðrýlacak metod
    public void DusmanOldur()
    {
        dusmanSayisi--; // Düþman sayýsýný azalt
        if (dusmanSayisi <= 0)
        {
            OyunuBitir(); // Düþman sayýsý sýfýr veya daha az ise oyunu bitir
        }
    }

    // Oyunu bitiren metod
    void OyunuBitir()
    {
        Debug.Log("Tebrikler! Oyunu kazandýnýz.");
        // Oyunu istediðiniz þekilde bitirebilirsiniz, örneðin oyunu durdurabilir veya menüye geçiþ yapabilirsiniz.
    }
}
