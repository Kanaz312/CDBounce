using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Vector3 move;
    private Vector3 halfScale;
    private bool paused;
    private SpriteRenderer spriteRenderer;

    void Start()
    {  
        int x_vel = Random.value > 0.5 ? -1:1;
        int y_vel = Random.value > 0.5 ? -1:1;
        this.move = new Vector3(x_vel, y_vel, 0);
        this.spriteRenderer = transform.GetComponent<SpriteRenderer>();
        this.halfScale = spriteRenderer.bounds.size / 2;
        this.paused = false;
        spriteRenderer.color = Random.ColorHSV();
    }

    void Update(){ 
        if (Input.GetKeyDown("space")){
            paused = !paused;
            Time.timeScale = 1 - Time.timeScale;
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    
    void FixedUpdate()
    {
        if (!paused){
            bool bounced = false;
            transform.Translate(move);
            Vector2 topRight = Camera.main.WorldToViewportPoint(transform.position + halfScale);
            Vector2 bottomLeft = Camera.main.WorldToViewportPoint(transform.position - halfScale);
            if(bottomLeft.x < 0.0){
                move.x = -move.x;
                transform.position.Set(0.0f, bottomLeft.y, 0);
                bounced = true;
            }
            else if (1.0 < topRight.x){
                move.x = -move.x;
                transform.position.Set(1.0f, topRight.y, 0);
                bounced = true;
            }
            if (bottomLeft.y < 0.0){
                move.y = -move.y;
                transform.position.Set(bottomLeft.x, 0, 0);
                bounced = true;
            }
            else if (1.0 < topRight.y){
                move.y = -move.y;
                transform.position.Set(topRight.x, 1, 0);
                bounced = true;
            }
            if (bounced) colorChange();
        }
    }

    void colorChange(){
        Color original = spriteRenderer.color;
        Color newColor = Random.ColorHSV();
        while (original == newColor){
            newColor = Random.ColorHSV();
        }
        spriteRenderer.color = newColor;
    }
}
