using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            transform.parent.GetComponent<Rigidbody>().useGravity = true;
            Invoke("AfterFallFinished", 3f);
        }
    }


    void AfterFallFinished()
    {
        FindObjectOfType<PlatformSpawner>().DecreaseNumberPlatforms();
        Destroy(transform.parent.gameObject);
    }
}
