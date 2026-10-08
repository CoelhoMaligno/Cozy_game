using UnityEngine;

public class Player_Movimentação : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
Vector2 movimento = new Vector2 (x, y);
        transform.Translate(movimento * velocidade * Time.deltaTime);
    }
}
