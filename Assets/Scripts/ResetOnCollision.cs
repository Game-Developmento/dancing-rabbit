using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string triggerTag;
    private void OnCollisionEnter(Collision other) {
        if (gameObject.activeSelf && triggerTag == other.collider.tag)
        {
            SceneManager.LoadScene("level-1");

        }
    }
}
