using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string triggerTag;
    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.activeSelf && triggerTag == other.tag)
        {
            Destroy(gameObject);

        }
    }
}
