using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public Transform greenButton;
    public Transform redButton;
    public Transform yellowButton;
    public Transform blueButton;
    public Transform orangeButton;
    public Transform strumBar;

    string[] name = { "Green", "Red", "Yellow", "Blue", "Orange" };
    Transform[] transforms;
    
    void Start ()
    {
        transforms = new Transform[] { greenButton, redButton, yellowButton, blueButton, orangeButton };
    }

    void Update()
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (Input.GetButton("button" + name[i]))
            {
                if (transforms[i].localPosition.y != -0.006f)
                    transforms[i].localPosition = new Vector3(transforms[i].localPosition.x, -0.006f, transforms[i].localPosition.z);
            }
            else
            {
                if (transforms[i].localPosition.y != 0)
                    transforms[i].localPosition = new Vector3(transforms[i].localPosition.x, 0, transforms[i].localPosition.z);
            }
        }

        if (Input.GetButton("strumUp"))
        {
            if (strumBar.localEulerAngles.x != -30)
                strumBar.localEulerAngles = new Vector3(-30, strumBar.localEulerAngles.y, strumBar.localEulerAngles.z);
        }
        else if (Input.GetButton("strumDown"))
        {
            if (strumBar.localEulerAngles.x != 30)
                strumBar.localEulerAngles = new Vector3(30, strumBar.localEulerAngles.y, strumBar.localEulerAngles.z);
        }
        else
        {
            if (strumBar.localEulerAngles.x != 0)
                strumBar.localEulerAngles = new Vector3(0, strumBar.localEulerAngles.y, strumBar.localEulerAngles.z);
        }
    }
}
