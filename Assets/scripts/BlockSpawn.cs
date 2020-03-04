using UnityEngine;
    
public class BlockSpawn : MonoBehaviour
{
    public Transform coinPrefab;
    
    void OnCollisionEnter2D(Collision2D c)
    {
        // The position check may need to be better.
        if (c.collider.tag == "Player"){
            Debug.Log("hit");
            Instantiate(coinPrefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
        }
    }
}
