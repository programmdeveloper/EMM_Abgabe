using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int score = 0;
    float angle = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        angle += moveHorizontal * 0.5f * Time.deltaTime;
        Vector3 moveDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
        transform.localRotation = Quaternion.LookRotation(moveDirection);
        transform.position += transform.forward * Time.deltaTime * moveVertical;
        Debug.Log("Rotation: " + angle);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            score++;
            Debug.Log("Score: " + score);
        }
    }

}
