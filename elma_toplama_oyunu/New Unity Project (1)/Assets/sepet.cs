using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sepet : MonoBehaviour
{

    public float hiz;
    int skor=0;
    TMPro.TextMeshProUGUI score_txt;

    void Start()
    {
        score_txt = GameObject.Find("Canvas/score_txt").GetComponent<TextMeshProUGUI>();
        
    }


    private void OnCollisionEnter(Collision collision)//ilk çarpýþmad kodlarýn çalýþmasýný istiyorum.
    {
        if (collision.gameObject.tag == "elma")
        {
            skor += 10;
           
            //Debug.Log(skor.ToString());
            score_txt.text = skor.ToString();//oyun ekranýna yazdýrmak.

            Destroy(collision.gameObject);

            //float rast = Random.Range(13.57f, 27.44f);

            //collision.gameObject.transform.position = new Vector3(rast, -14.24f, -43.69f);
        }


    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }





    }
}
