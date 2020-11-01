using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
using TMPro;
using System;

public class Player : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject endMessage; // all elements are gameObject
    private int count;
    public Boolean isMobileBuild;   
    void Start()
    {
        count = 0; //initiate count 
        endMessage.SetActive(false); //disable the end message
        
        SetCountText();
        if (isMobileBuild)
        {
            // enable readingsensor values
            //InputSystem.EnableDevice(UnityEngine.InputSystem.Accelerometer.current);
        }
    }
    void SetCountText()
    {
        countText.text = "Score : " + count.ToString();
        if (count >= 25)
        {
            endMessage.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false); //PickUp objects disapeared
            count += 1; //the score increase by one
            
        }
    }
}
