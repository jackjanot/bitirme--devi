using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ateset : MonoBehaviour
{
    Camera kamera;
    public LayerMask zombiKatman;
    // Start is called before the first frame update
    void Start()
    {
        kamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        AtesEtme();
        if (Input.GetMouseButton(0)) ;
    }
     void AtesEtme()
    {
        Ray ray = kamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, zombiKatman))
        {
            hit.collider.gameObject.GetComponent<zombi>().HasarAl();
        }

    } 
}
