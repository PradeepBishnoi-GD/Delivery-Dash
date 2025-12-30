using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("mujhse takrayega tu");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("tata, byby");
    }
}
