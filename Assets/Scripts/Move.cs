using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 3.0f;
    float rotationSpeed = 50.0f;
    float jumpPower = 100.0f;
    Animator anim;
    Rigidbody rb;
    public bool land;
    public Transform landDetection;
    
    void Start()
    {
        anim = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
        land = true;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }

        if (rotation != 0)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }

        JumpFun();
    }

    void JumpFun()
    {
        float jump = Input.GetAxis("Jump");

        Collider[] hitColliders = Physics.OverlapSphere(landDetection.position, 0.0004f);
        foreach(Collider hitCollider in hitColliders)
        {
            if (hitCollider.gameObject.name == "Land")
            {
                land = true;
            }
        }

        if (jump != 0 && land == true)
        {
            anim.SetBool("jump", true);
            rb.AddForce(Vector3.up * jumpPower);
            land = false;
        }
        else
        {
            anim.SetBool("jump", false);
        }

    }
}
