using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float constantMovemement;

    private Rigidbody2D rb;
    private Rigidbody2D rb2;
    private float moveDirectionHorizontal;
    private float moveDirectionVertical;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //Get inputs
        moveDirectionVertical = Input.GetAxis("Vertical");
        moveDirectionHorizontal = Input.GetAxis("Horizontal") + constantMovemement;
        

        //Move
        rb.velocity = new Vector2(moveDirectionVertical * moveSpeed, rb.velocity.y);
        rb2.velocity = new Vector2(moveDirectionHorizontal * moveSpeed, rb.velocity.x);
    }
}
