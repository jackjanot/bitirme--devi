
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Transform oyuncu; // Oyuncuyu takip edecek transform
    public float takipHizi = 2.0f; // Kameran�n takip h�z�
    public float yatayHassasiyet = 2.0f; // Yatay d�n�� hassasiyeti
    public float dikeyHassasiyet = 2.0f; // Dikey d�n�� hassasiyeti

    float yatayRotasyon = 0.0f;
    float dikeyRotasyon = 0.0f;
    Vector3 objRot;
    public Transform karakterVucut;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Fareyi ortalamak i�in
    }

    void Update()
    {
        // Fare giri�lerini al
        yatayRotasyon += Input.GetAxis("Mouse X") * yatayHassasiyet;
        dikeyRotasyon -= Input.GetAxis("Mouse Y") * dikeyHassasiyet;

        // Dikey rotasyonu s�n�rla
        dikeyRotasyon = Mathf.Clamp(dikeyRotasyon, -90f, 90f);

        // Kameran�n rotasyonunu g�ncelle
        transform.rotation = Quaternion.Euler(dikeyRotasyon, yatayRotasyon, 0);

        // Oyuncuyu takip et
        if (oyuncu != null)
        {
            Vector3 yeniPozisyon = oyuncu.position - transform.forward * 5.0f;
            transform.position = Vector3.Lerp(transform.position, yeniPozisyon, Time.deltaTime * takipHizi);

            // Oyuncuyu kameran�n d�n���ne g�re d�nd�r
            oyuncu.rotation = Quaternion.Euler(0, yatayRotasyon, 0);
          
        }

    }
    private void LateUpdate()
    {
        if (dikeyRotasyon >= 40)
        {
            dikeyRotasyon = 40;
        }
        if (dikeyRotasyon <= 5)
        {
            dikeyRotasyon = 5;
        }
        /*Vector3 gecici = this.transform.localEulerAngles;
        gecici.z = 0;
        gecici.y = this.transform.localEulerAngles.y;
        gecici.x = this.transform.localEulerAngles.x ;
        objRot = gecici;
        karakterVucut.transform.eulerAngles = objRot;*/
    }
}
