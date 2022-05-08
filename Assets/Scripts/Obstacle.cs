using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private GameObject torus;
    [SerializeField]
    private MovementEnum movement;

    public GameObject Torus { get => torus; set => torus = value; }
    public MovementEnum Movement { get => movement; set => movement = value; }
    public TorusMovement TorusMovement { get; set; } = null;

    public bool Lose = false;
    public bool Pkt = false;

    public void CheckJump()
    {
        if (Lose == true && Pkt == true)
        {
            PointsManager.Instance.AddPoints(3);
        }
        else if (Lose == true && Pkt == false)
        {
            PointsManager.Instance.AddPoints(-PointsManager.Instance.Points);
        }
        else if (Lose == false && Pkt == false)
        {
            PointsManager.Instance.AddPoints(1);
        }
    }

    public void Init()
    {
        switch (Movement)
        {
            case MovementEnum.LeftRight:
                TorusMovement = new MovementSimpleLeftRight();
                break;
            case MovementEnum.UpDown:
                TorusMovement = new MovementSimpleUpDown();
                break;
            case MovementEnum.SimpleX:
                TorusMovement = new MovementSimpleX();
                break;
            case MovementEnum.SimpleCircle:
                TorusMovement = new MovementSimpleCircle();
                break;
            default:
                TorusMovement = new MovementSimpleLeftRight();
                break;
        }
        TorusMovement.SetMovement(Torus.transform);
    }

    public void Kill()
    {
        TorusMovement.Kill(Torus.transform);
        transform.DOKill();
    }

    public void Move()
    {
        transform.DOMoveZ(transform.position.z - 10, 1);
    }

}
