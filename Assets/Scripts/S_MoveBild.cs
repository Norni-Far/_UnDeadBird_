using UnityEngine;

public class S_MoveBild : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 0.15f;   // должна быть почти такая же как и скорось сданий 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()  // 
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
            rb.transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
            Destroy(gameObject);
    }


}
