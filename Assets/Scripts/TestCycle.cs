using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log(1);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(3);
    }
}
