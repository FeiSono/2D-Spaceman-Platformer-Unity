using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] private AudioSource Trampolinee;
    private float bounce = 20f;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            Jump();
            anim.Play("Trampoline_Jump");
            
           

        }
    }

    private void Jump()
    {
        Trampolinee.Play();
        Debug.Log("Jump");
        
    }
}
