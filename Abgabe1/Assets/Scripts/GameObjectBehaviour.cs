using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviour : MonoBehaviour
{

    public Transform myPrefab;
    public Transform parentobj;
    private int anzahl = 25;

    // Start is called before the first frame update
    void Start()
    {
        //anzahl = UnityEngine.Random.Range(1, 7);
        for(int i = 0; i < anzahl; i++) {
            Instantiate(myPrefab, new Vector3(UnityEngine.Random.Range(-5f, 5f), 1, UnityEngine.Random.Range(-5f, 5f)), Quaternion.identity, parentobj);
            //myPrefab.transform.SetParent(parentobj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
