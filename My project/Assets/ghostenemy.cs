using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostenemy : EnemyController
{
    // Start is called before the first frame update
    void Start()
    {
                sr=GetComponent<SpriteRenderer>();

        sr.flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
    if(sr.flipX==false){
        this.GetComponent<Rigidbody2D>().velocity=new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
    }
    else {
        this.GetComponent<Rigidbody2D>().velocity= new Vector2(maxSpeed,this.GetComponent<Rigidbody2D>().velocity.y);
    }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag =="Player"){
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Flip();
        }
    }
}
