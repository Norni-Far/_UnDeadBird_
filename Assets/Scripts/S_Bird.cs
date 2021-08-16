using UnityEngine;

public class S_Bird : MonoBehaviour
{
    //
    public S_Statistics S_Stat;
    //


    public GameObject Explosion;
    public GameObject Btn_Jump;
    public GameObject Btn_Replay;


    Rigidbody2D rb;
    public float PowerUp;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Gump()
    {
        rb.AddForce(transform.up * PowerUp, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bild")
        {
            Instantiate(Explosion, gameObject.transform.position, gameObject.transform.rotation);
            Btn_Jump.SetActive(false);
            Btn_Replay.SetActive(true);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Stat")
        {
            S_Stat.SetResult();
        }
    }
}
