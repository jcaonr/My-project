using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    bool test = true;
    // Start is called before the first frame update
    void Start()
    {
        if(test)
        {
            test = false;
            Debug.Log("test start");
            gameObject.transform.position = new Vector3(0, 0,0 );
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.name = "Oli test game";
    }
    void Testscript2()
    {
        Debug.Log("");
        DontDestroyOnLoad(gameObject);
    }
}
