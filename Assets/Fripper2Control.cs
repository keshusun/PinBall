using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fripper2Control : MonoBehaviour
{

    private HingeJoint myHingejoint;

    private float defaultAbgle = 20.0f;

    private float flickAngle = -20.0f;
    // Start is called before the first frame update
    void Start()
    {

        this.myHingejoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAbgle);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if(Input.GetKeyDown(KeyCode.D) && tag =="RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetAngle(this.flickAngle);
        }
        if(Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAbgle);
        }
        if(Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAbgle);
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            SetAngle(this.defaultAbgle);
        }
    }

    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingejoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingejoint.spring = jointSpr;
    }
}
