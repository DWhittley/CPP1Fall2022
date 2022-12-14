using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Entered");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exited");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Entered");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision Exited");
    }
}
