using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Animator animator;
    public float velocidade = 5f;
    float velocidadeX, velocidadeY;
    public Rigidbody2D rb;
    Vector2 movimento;

    // Start is called before the first frame update
    void Start()
    {   
        
        rb = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movimento.x);
        animator.SetFloat("Vertical", movimento.y);
        animator.SetFloat("Speed", movimento.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimento * velocidade * Time.fixedDeltaTime);

    }
}