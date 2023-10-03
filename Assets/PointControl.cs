using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PointControl : MonoBehaviour
{

    private GameObject pointText;


    public int total = 0;
    // Start is called before the first frame update
    void Start()
    {     
        this.pointText = GameObject.Find("Test1");
        Debug.Log(pointText);
        this.pointText.GetComponent<Text>().text = "Total Point" + total;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            Pointenter(5);   
        }
        else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "SmallCloudTag")
        {
            Pointenter(10);
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Pointenter(20);
        }
    }
   public void Pointenter(int score)
    {
        total += score;
        this.pointText.GetComponent<Text>().text = "Total Point" + total;
    }
}
