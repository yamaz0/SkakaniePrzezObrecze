using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MapController : MonoBehaviour
{
    private const int OBJECTS_COUNT = 4;
    [SerializeField]
    private List<Obstacle> obstacles = new List<Obstacle>();

    private List<Obstacle> ObstaclesSpawns { get; set; } = new List<Obstacle>(OBJECTS_COUNT);

    public void StartGame()
    {
        for (int i = 0; i < OBJECTS_COUNT; i++)
        {
            Obstacle item = Instantiate(obstacles[0], new Vector3(0, 0, 10 * i), Quaternion.identity, transform);
            item.Init();
            ObstaclesSpawns.Add(item);
        }
    }

    public void MapUpdate()
    {
        foreach (Obstacle obstacle in ObstaclesSpawns)
        {
            obstacle.Move();
        }

        Obstacle lastObstacle = ObstaclesSpawns[0];

        int randomId = Random.Range(0, obstacles.Count);
        Obstacle item = Instantiate(obstacles[randomId], transform);
        item.Init();

        ObstaclesSpawns.Remove(lastObstacle);
        ObstaclesSpawns.Add(item);

        lastObstacle.transform.DOMoveZ(-10, 1).OnComplete(() =>
        {
            lastObstacle.CheckJump();
            lastObstacle.Kill();
            Destroy(lastObstacle.gameObject);
        });

    }
}
