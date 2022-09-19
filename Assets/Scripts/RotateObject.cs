using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
[Serializable]

public class RotateObject : MonoBehaviour
{
    bool plzSpin = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plzSpin)
        {
            this.transform.Rotate(5f * Time.deltaTime, 5f * Time.deltaTime, 5f * Time.deltaTime);
        }
    }

    public void timeToSpin()
    {
        plzSpin = true; 
    }


}
