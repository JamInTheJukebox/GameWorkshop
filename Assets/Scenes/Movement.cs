using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed; 
    private void Awake()
    {
        print("Awake");
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countEverySecond());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontalSpeed = 0;
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.A))
        {
            horizontalSpeed = (Input.GetKey(KeyCode.D)) ? Speed : Speed * -1;
        }
        // rb.velocity = Input.GetAxis("horizontal") * Speed;
        rb.velocity = new Vector2(horizontalSpeed, rb.velocity.y);
    }

    public IEnumerator countEverySecond()
    {
        int counter = 0;
        while (true)
        {
            yield return new WaitForSeconds(1);
            print(counter++);
            if(counter > 100)
            {
                break;
            }
            FindObjectOfType<GlobalTimer>().counter = counter;
        }
    }

    private void OnDestroy()
    {
        
    }

}
