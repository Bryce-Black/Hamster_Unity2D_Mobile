using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TouchJump : MonoBehaviour
{
    Vector2 touchPosWorld;
    Rigidbody2D rb;
    
    
    
    
    //Change me to change the touch phase used.
    readonly TouchPhase touchPhase = TouchPhase.Ended;
    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * 450f);
        
    }

    public void Update()
    {
        //We check if we have more than one touch happening.
        //We also check if the first touches phase is Ended (that the finger was lifted)
        if (Input.touchCount > 0 && Input.touches[0].phase == touchPhase)
        {

            

            //We transform the touch position into word space from screen space and store it.
            touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            

            Vector2 touchPosWorld2D = new(touchPosWorld.x, touchPosWorld.y);

            //We now raycast with this information. If we have hit something we can process it.
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);
            
            if (hitInformation.collider != null)
            {
                //We should have hit something with a 2D Physics collider!
                GameObject touchedObject = hitInformation.transform.gameObject;
                //touchedObject should be the object someone touched.
                Debug.Log("Touched " + touchedObject.transform.name);
                if(touchedObject)
                {                  
                    rb.AddForceAtPosition(Vector2.up * 650f, touchPosWorld2D, ForceMode2D.Force);
                    


                }
            }
        }
    }
}
