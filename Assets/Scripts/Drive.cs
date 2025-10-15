using Unity.VisualScripting;
using UnityEngine;

public class drive : MonoBehaviour
{
    [SerializeField] float move=10f;
    [SerializeField] float rotate=150f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float fastSpeed = 20f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Booster")
        {
            move = fastSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Wham!!!");
        move = slowSpeed;
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * rotate * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * move * Time.deltaTime;

        transform.Translate(0,moveAmount,0);
        transform.Rotate(0,0,-steerAmount);
    }
}
