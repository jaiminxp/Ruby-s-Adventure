using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        var controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.Health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }

    }
}
