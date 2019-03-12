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
    }
}
