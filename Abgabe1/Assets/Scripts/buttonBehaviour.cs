using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonBehaviour : MonoBehaviour
{
    public Transform player;
    VirtualButtonBehaviour[] vbs;
    private bool up = false;
    private bool down = false;
    private bool left = false;
    private bool right = false;
    float ang = 0;

    // Start is called before the first frame update
    void Start()
    {
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "UpButton":
                up = true;
                Debug.Log("Up pressed");
                break;
            case "DownButton":
                down = true;
                Debug.Log("down pressed");
                break;
            case "LeftButton":
                left = true;
                Debug.Log("left pressed");
                break;
            case "RightButton":
                right = true;
                Debug.Log("right pressed");
                break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "UpButton":
                up = false;
                Debug.Log("Up released");
                break;
            case "DownButton":
                down = false;
                Debug.Log("down released");
                break;
            case "LeftButton":
                left = false;
                Debug.Log("left released");
                break;
            case "RightButton":
                right = false;
                Debug.Log("right released");
                break;
        }
    }

    void Update()
    {
        if (up)
        {
            player.position += player.forward * Time.deltaTime * 0.3f;
        }
        if (down)
        {
            player.position += player.forward * Time.deltaTime * -0.3f;
        }
        if (left)
        {
            ang += -1.0f * 0.5f * Time.deltaTime;
            Vector3 moveDirection = new Vector3(Mathf.Sin(ang), 0, Mathf.Cos(ang));
            player.localRotation = Quaternion.LookRotation(moveDirection);
            Debug.Log("Rotation: " + ang);
        }
        if (right)
        {
            ang += 1.0f * 0.5f * Time.deltaTime;
            Vector3 moveDirection = new Vector3(Mathf.Sin(ang), 0, Mathf.Cos(ang));
            player.localRotation = Quaternion.LookRotation(moveDirection);
        }
    }
}
