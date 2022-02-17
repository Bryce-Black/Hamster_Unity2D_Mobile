using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TouchJumpFun : MonoBehaviour
{
    Vector2 touchPosWorld;
    private Rigidbody2D rb;
    public int FunScore;

    public Text Mulitplier;

    public bool TimesOne = false;
    public bool TimesTwo = false;
    public bool TimesThree = false;
    public bool TimesFive = false;
    public bool TimesTen = false;



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
            Vector2 swag = new(0, -5);
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);
            //RaycastHit2D hitInformation = Physics2D.Raycast(swag, touchPosWorld2D);
            Debug.DrawRay(swag, touchPosWorld2D, Color.red);

            if (hitInformation.collider != null)
            {
                //We should have hit something with a 2D Physics collider!
                GameObject touchedObject = hitInformation.transform.gameObject;
                //touchedObject should be the object someone touched.
                Debug.Log("Touched " + touchedObject.transform.name);
                if (touchedObject)
                {
                    rb.AddForceAtPosition(touchPosWorld * 100f, touchPosWorld2D, ForceMode2D.Force);
                    //rb.AddForceAtPosition(Vector2.up * 620f, touchPosWorld2D, ForceMode2D.Force);
                    rb.AddForce(Vector2.up * 700f, ForceMode2D.Force);
                    if (FunScore < 10)
                    {
                        FunScore += 1;
                        TimesOne = true;
                        if (TimesOne)
                        {
                            Mulitplier.text = "1x";
                        }
                    }
                    else if (FunScore < 20)
                    {
                        FunScore += 2;
                        TimesTwo = true;
                        if(TimesTwo)
                        {
                            Mulitplier.text = "2x";
                        }
                    }
                    else if(FunScore < 50)
                    {
                        FunScore += 3;
                        TimesThree = true;
                        if (TimesThree)
                        {
                            Mulitplier.text = "3x";
                        }
                    }
                    else if (FunScore < 100)
                    {
                        FunScore += 5;
                        TimesFive = true;
                        if (TimesFive)
                        {
                            Mulitplier.text = "5x";
                        }
                    }
                    else
                    {
                        FunScore += 10;
                        TimesTen = true;
                        if (TimesTen)
                        {
                            Mulitplier.text = "10x";
                        }
                    }
                }
            }
        }
    }
}
