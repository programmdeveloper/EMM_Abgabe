using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private float slerp = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 offsetRotated = playerRotation * offsetVector;
        Vector3 offsetRotated = target.rotation * offset;
        transform.position = target.position + offsetRotated;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position, Vector3.up),slerp);
        slerp += Time.deltaTime;
    }
}
