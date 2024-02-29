public GameObject uzaklik;
float eklenecekSaglik;
public Text bilgi;
public Text gameOverText;
public Button btn;







void Start()
{
    anim = this.GetComponent<Animator>();
    hayattaMi = true;
    bilgi.enabled = true;
    gameOverText.gameObject.SetActive(false);
    //UpdateHealth();

}


// Update is called once per frame
void Update()
{

    eklenecekSaglik = maxHealth - saglik;
    bilgi.enabled = false;


    saglikBari.text = "" + saglik;
    if (Physics.Raycast(uzaklik.transform.position, uzaklik.transform.forward, out hit, 4f))
        if (hit.transform.tag == "saglikpaketi")
        {
            bilgi.enabled = true;
            bilgi.text = " SAÐLIK PAKETÝ ALMAK ÝÇÝN E TUÞUNA BAS";
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hit.transform.gameObject);
                saglik += eklenecekSaglik;
            }

        }
    Hareket();

    if (saglik <= 0)
    {

        hayattaMi = false;
        anim.SetBool("yasiyorMu", hayattaMi);

    }
    if (hayattaMi == true)
    {
        Hareket();
    }
    else if (hayattaMi == false)
    {
        anim.SetBool("yasiyorMu", hayattaMi);
        // Saðlýk sýfýrlandýðýnda Oyunu Kaybettiniz mesajýný göster
        gameOverText.gameObject.SetActive(true);
        anim.SetBool("yasiyorMu", hayattaMi);




    }

}


public void HasarAl()
{
    saglik -= Random.Range(10, 20);


}
void Hareket()
{
    float yatay = Input.GetAxis("Horizontal");
    float dikey = Input.GetAxis("Vertical");
    anim.SetFloat("Horizontal", yatay);
    anim.SetFloat("Vertical", dikey);
    this.gameObject.transform.Translate(yatay * karakterHiz * Time.deltaTime, 0, dikey * karakterHiz * Time.deltaTime);



}
   
}

