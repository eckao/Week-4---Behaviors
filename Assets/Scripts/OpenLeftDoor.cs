using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class OpenLeftDoor : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{


    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    UnityEngine.Vector3 position = this.transform.position;
    //    position.z = position.z - 5;
    //    this.transform.position = position;
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    SomeMethod();
    //    UnityEngine.Vector3 position = this.transform.position;
    //    position.z = position.z + 5;
    //    this.transform.position = position;

    //}

    //private void OnTriggerStay(Collider other)
    //{
    //    UnityEngine.Debug.LogFormat("{0} trigger stay: {1}", this, other);
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    UnityEngine.Debug.LogFormat("{0} trigger exit: {1}", this, other);
    //}

    public float maximumOpening = 10f;
    public float maximumClosing = 0f;

    public float movementSpeed = 5f;

    bool playerIsHere;
    bool needClose;


    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        needClose = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            if (this.transform.position.z < maximumOpening)
            {

                this.transform.Translate(0f, 0f, -movementSpeed * Time.deltaTime);

            }
            
        }
        else
        {
            if (this.transform.position.z < -4f)
            {

                 this.transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
                
            }
            
            
        }


    }

    private void OnTriggerEnter(Collider col)
    {
        //needClose = true;
            playerIsHere = true;
        
    }

    private void OnTriggerExit(Collider col)
    {
            
            playerIsHere = false;
        
    }
}

