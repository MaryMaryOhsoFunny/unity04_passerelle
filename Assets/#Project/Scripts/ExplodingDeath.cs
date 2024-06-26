using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingDeath : MonoBehaviour
{
    
    public void Die()
    {
        Debug.Log("Bouuuuum!");
        Destroy(gameObject);
    }
}
