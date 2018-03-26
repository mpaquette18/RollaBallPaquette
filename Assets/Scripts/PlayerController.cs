using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;
    private bool isGrounded=false;

    public Text countText;
    public Text winText;
    public int count;

    public GameObject player;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = player.GetComponent<moveBall>().rollX;
        float moveVertical = player.GetComponent<moveBall>().rollY;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce(movement * speed);
        if (Input.GetKeyDown(KeyCode.Space)&&isGrounded) {
            rb.AddForce(new Vector3(0, 500, 0));
            isGrounded = false;
            Debug.Log("UnGrounded");
        }
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<floor>()!=null) {
            isGrounded = true;
            Debug.Log("Grounded");
        }
    }

    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 6)
        {
            winText.text = "You Win!";
        }
    }
}