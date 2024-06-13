using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    bool test
    // Start is called before the first frame update
    void Start()
    {
        if(test)
        {
            test = false;
            Debug.Log("test start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
