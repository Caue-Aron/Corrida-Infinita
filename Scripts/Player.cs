using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator animator;
    public float jumpHeight;
    public float xVelocity;
    public Text txtScore;
    public AudioSource audio;

    private bool grounded;
    private Rigidbody2D body; 

    private int pontos;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        xVelocity = xVelocity * 0.95f;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "fruta"){
            Destroy(other.gameObject);
            pontos++;
            txtScore.text = "Pontuação: " + pontos.ToString(); 
            audio.Play();
        }
        else if(other.gameObject.tag == "morte"){
            SceneManager.LoadScene("gameover");
        }
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(xVelocity, body.velocity.y);

        Debug.Log(Input.touchCount);

        if (Input.GetKeyDown("space") || Input.touchCount > 0)
        {
            if (grounded)
            {
                body.velocity = new Vector2(body.velocity.y, jumpHeight);
                animator.SetBool("pulando", true);
            }
        }

        if (body.velocity.y == 0) {
            grounded = true;
            animator.SetBool("pulando", false);
            animator.SetBool("caindo", false);
        }
        else
            if(body.velocity.y > 0) {
                animator.SetBool("pulando", true);
                animator.SetBool("caindo", false);
                grounded = false;
            }
            else{
                animator.SetBool("pulando", false);
                animator.SetBool("caindo", true);
                grounded = false;
            }
    }
}
