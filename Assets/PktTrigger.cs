using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PktTrigger : MonoBehaviour
{
    [SerializeField]
    private Obstacle obstacle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
            obstacle.Pkt = true;
    }
}
