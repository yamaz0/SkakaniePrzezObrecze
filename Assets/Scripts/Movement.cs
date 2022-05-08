using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Jump()
    {
        transform.DOJump(new Vector3(0, 0, -5), 1, 1, 1);
    }
}
