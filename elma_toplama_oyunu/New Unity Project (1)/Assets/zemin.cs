using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//image ve butonlar için gerekli kütüphane.

public class zemin : MonoBehaviour
{
    float can=100.0f;
    float su_anki_can = 100.0f;
    Image can_bari;//kod dosyasýnda deðer atýyacaðým.
    public GameObject panel;

    private void Start()
    {
        can_bari = GameObject.Find("Canvas/Image/can_bari").GetComponent<Image>();
    }






    private void OnCollisionEnter(Collision collision)//ilk çarpýþmad kodlarýn çalýþmasýný istiyorum.
    {
        if (collision.gameObject.tag == "elma")
        {
            Destroy(collision.gameObject);

            su_anki_can -= 10.0f;
            can_bari.fillAmount = su_anki_can / can;  //0-1 arasý bir deðer alacak.

            if (su_anki_can <= 0)
            {
                panel.SetActive(true); 
                Time.timeScale = 0.0f;
            }




            //float rast = Random.Range(13.57f, 27.44f);

            //collision.gameObject.transform.position = new Vector3(rast, -14.24f, -43.69f);
        }
 

    }
}
