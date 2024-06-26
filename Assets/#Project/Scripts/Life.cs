using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] int maxPV;
    [SerializeField] int currentPV;

    // Start is called before the first frame update
    void Start()
    {
        currentPV = maxPV;
    }

    public void GetHit(int amount)
    {
        currentPV -= amount;
        if (currentPV <= 0)
        {
            IDie death = GetComponent<IDie>();
            death.Die();
        }
    }
}