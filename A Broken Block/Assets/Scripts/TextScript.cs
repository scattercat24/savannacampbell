using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : PlayerScript
{
    public Image image;
    

    public float delay = 0.1f;
    
    public float speed;
    public TextMeshProUGUI mytxt;


    private string currentText = "";
    private string emptyString = " ";
    



    void Start()
    {
        
        
        TextMeshProUGUI mytxt = GameObject.Find("Canvas/Image/MainText").GetComponent<TextMeshProUGUI>();
        speed = 10f;
        
        StartCoroutine(ShowText("Where am I? "));
    }



    void Update()
    {
        if (wife == true)
        {
            Debug.Log(wife = true);
            image.GetComponent<Image>().color = new Color32(145, 61, 136, 1);

        }
        else if (daughter == true)
        {
        }
        else if (son == true)
        {
        }
        else
        {

        }
    }


   


















    IEnumerator ShowText(string fullText)
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            mytxt.text = currentText;
            yield return new WaitForSeconds(delay);
            
        }

        yield return new WaitForSeconds(3);
        mytxt.text = emptyString;
        if (fullText == "Where am I? ")
        {
            StartCoroutine(ShowText("Well I might as well look around. "));

            
        }
    }

    public void ChangeColor()
    {
        image.color = Color.red;
    }



        

    
        
    

    
    
}

