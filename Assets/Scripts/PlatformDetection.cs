using UnityEngine;

public class PlatformDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        RaycastHit hit;
        if(!Physics.Raycast(transform.position, Vector3.down, Mathf.Infinity))
        {
            FindObjectOfType<GameManager>().GameEnds();
            GetComponent<Movement>().SetGameOver();
        }
    }
}
