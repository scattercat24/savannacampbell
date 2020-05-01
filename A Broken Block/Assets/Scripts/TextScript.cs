using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    public float delay = 0.1f;
    
    public float speed;
    public TextMeshProUGUI mytxt;


    private string currentText = "";
    private string emptyString = " ";
    private bool welp = false;




    void Start()
    {
        TextMeshProUGUI mytxt = GameObject.Find("Canvas/Image/MainText").GetComponent<TextMeshProUGUI>();
        speed = 10f;
        
        StartCoroutine(ShowText("Where am I? "));
    }



    void Update()
    {

    }








    














IEnumerator ShowText(string fullText)
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            Debug.Log(i);
            currentText = fullText.Substring(0, i);
            mytxt.text = currentText;
            yield return new WaitForSeconds(delay);
            
        }

        Debug.Log("Done");
        yield return new WaitForSeconds(3);
        mytxt.text = emptyString;
        if (fullText == "Where am I? ")
        {
            StartCoroutine(ShowText("Well I might as well look around. "));

            
        }
    }

    
        
    

    
    
}

