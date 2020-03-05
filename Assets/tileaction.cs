using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tileaction : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spr;
    public Rigidbody2D rb;
    public float speed = 200f;
    private bool isChecked=false;
    private int i = 1;
    void Start()
    {
        isChecked = false;
    }

    // Update is called once per frame
    void Update()
    {   
        rb.velocity = new Vector3(0,-speed*Time.deltaTime,0);
        if(FindObjectOfType<score>().tempScore>i*10){
            speed+=100f;
            i++;
        }
    }

    private void OnMouseOver() {

        if(Input.GetMouseButtonDown(0)){
            if(!isChecked){
                spr.color = Color.yellow;
                FindObjectOfType<score>().ScoreUpdate(1);
                isChecked = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(spr.color == Color.yellow){
            Debug.Log("nigga you fine");
        }else if(other.collider.tag=="border"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
