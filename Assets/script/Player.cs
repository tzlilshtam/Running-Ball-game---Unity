using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    [SerializeField]
    float speed = 0;
    [SerializeField]
    new Rigidbody rigidbody;

  

    double base_height = -3;
    
    Vector3 star_position = new Vector3((float)-0.22, 0, (float)-34.3);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity += new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.velocity += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.velocity += new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.velocity += new Vector3(0, 0, -speed);
        }
        
        // if the player fall from the ground the the position is set to the beginning
        if(gameObject.transform.position.y < base_height)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.tag == "wall")
        {

            FindObjectOfType<GameManager>().GameOver();

        }
        if (collision.gameObject.tag == "game_target")
        {
            
            FindObjectOfType<GameManager>().Complete();
        }
    }
}
