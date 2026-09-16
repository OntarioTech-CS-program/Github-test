using UnityEngine;

public class player : MonoBehaviour
{

    public int speed = 100;
    public GameObject youwin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * speed;
        if (Input.GetKey("d"))
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("flag"))
        {
            youwin.SetActive(true);
        }
    }
}
