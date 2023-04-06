using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoSlot : MonoBehaviour
{
    public float waitBeforeDestroy = 2.5f;
    public int slotScore = 0;

    private void OnTriggerEnter(Collider other)
    {
        PinkoDisk pd = other.GetComponentInParent<PinkoDisk>();
        if (pd)
        {
            //Debug.Log("disk scored points of " + slotScore);
            PlinkoManager.instance.AddScore(slotScore);
            Destroy(other.gameObject, waitBeforeDestroy);
        }
    }
}
