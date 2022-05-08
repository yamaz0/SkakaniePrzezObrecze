using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    [SerializeField]
    private Obstacle obstacle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
            obstacle.Lose = true;
    }
}
