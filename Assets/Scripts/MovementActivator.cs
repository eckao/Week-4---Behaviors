using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    //[SerializeField] GameObject objectToActivate;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    objectToActivate.GetComponent<MoveObject>().enabled = true;
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            UnityEngine.Vector3 position = this.transform.position;
            position.x += 5;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UnityEngine.Vector3 position = this.transform.position;
            position.x -= 5;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UnityEngine.Vector3 position = this.transform.position;
            position.y += 3;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            UnityEngine.Vector3 position = this.transform.position;
            position.y -=3;
            this.transform.position = position;
        }
    }

}
