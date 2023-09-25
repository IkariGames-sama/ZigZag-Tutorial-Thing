using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    Vector3 offset;
    bool willFollow = true;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
        FindObjectOfType<GameManager>().AddEventToGameEnd(delegate { willFollow = false; });
    }

    // Update is called once per frame
    void Update()
    {
        if (willFollow && target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
