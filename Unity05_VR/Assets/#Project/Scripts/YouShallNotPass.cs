using Unity.VisualScripting;
using UnityEngine;

public class YouShallNotPass : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Transform t = other.transform;
        t.position = new Vector3(t.position.x, 0.5f, t.position.z);

    }
    
}
