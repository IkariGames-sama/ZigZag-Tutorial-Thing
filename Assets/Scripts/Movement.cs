using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    bool xMov = true;
    bool canMove = false;
    GameManager gm;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameManager>();
        gm.AddEventToGameStart(delegate { canMove = true; });
        gm.AddEventToGameEnd(delegate { canMove = false; });
        //MovingX();
        //rb.velocity = speed * Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        // if (gm.GameStart && !gm.GameOver)
        //    { 
        //       canMove= true;
        //    } else
        //     { 
        //         canMove= false;
        //     }

        //if (gm.GameOver)
        //{ 
        //     canMove= false;
        //}

        if (canMove && Input.GetMouseButtonDown(0))
        {
            xMov = !xMov;
            if (xMov)
            {
                MovingX();
            } 
            else
            {
                MovingZ();
            }
        }
    }

    void MovingX()
    {
        rb.velocity = speed * Vector3.right;
    }
    void MovingZ()
    {
        rb.velocity = speed * Vector3.forward;
    }

    public void SetGameOver()
    {
        rb.useGravity= true;
        Invoke("DestroyBall", 5f);
    }

    void DestroyBall()
    {
        Destroy(gameObject);
    }
}
