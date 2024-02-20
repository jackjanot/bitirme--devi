
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Transform oyuncu; // Oyuncuyu takip edecek transform
    public float takipHizi = 2.0f; // Kameranýn takip hýzý
    public float yatayHassasiyet = 2.0f; // Yatay dönüþ hassasiyeti
    public float dikeyHassasiyet = 2.0f; // Dikey dönüþ hassasiyeti

    float yatayRotasyon = 0.0f;
    float dikeyRotasyon = 0.0f;
    Vector3 objRot;
    public Transform karakterVucut;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Fareyi ortalamak için
    }

    void Update()
    {
        // Fare giriþlerini al
        yatayRotasyon += Input.GetAxis("Mouse X") * yatayHassasiyet;
        dikeyRotasyon -= Input.GetAxis("Mouse Y") * dikeyHassasiyet;

        // Dikey rotasyonu sýnýrla
        dikeyRotasyon = Mathf.Clamp(dikeyRotasyon, -90f, 90f);

        // Kameranýn rotasyonunu güncelle
        transform.rotation = Quaternion.Euler(dikeyRotasyon, yatayRotasyon, 0);

        // Oyuncuyu takip et
        if (oyuncu != null)
        {
            Vector3 yeniPozisyon = oyuncu.position - transform.forward * 5.0f;
            transform.position = Vector3.Lerp(transform.position, yeniPozisyon, Time.deltaTime * takipHizi);

            // Oyuncuyu kameranýn dönüþüne göre döndür
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
