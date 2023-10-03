using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosz = -6.5f;

    public GameObject gameoverText;


    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("Test");
        Debug.Log(gameoverText);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosz)
        {
            
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
