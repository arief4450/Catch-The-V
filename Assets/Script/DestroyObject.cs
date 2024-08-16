using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private bool hasTouchedAnotherObject = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            hasTouchedAnotherObject = true;

            Destroy(gameObject, 2f);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            if (!hasTouchedAnotherObject)
            {
                ScoreManager.AddScore(1);
                Destroy(gameObject);
            }
        }
    }
}