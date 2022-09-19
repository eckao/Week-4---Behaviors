using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRightDoor : MonoBehaviour
{

    public float maximumOpening = 10f;
    public float maximumClosing = 0f;

    public float movementSpeed = 5f;

    bool playerIsHere;


    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            if (this.transform.position.z < maximumOpening)
            {
                this.transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (this.transform.position.z > maximumClosing)
            {
                this.transform.Translate(0f, 0f, -movementSpeed * Time.deltaTime);
            }
        }


    }

    private void OnTriggerEnter(Collider col)
    {

        playerIsHere = true;

    }

    private void OnTriggerExit(Collider col)
    {

        playerIsHere = false;

    }

}
