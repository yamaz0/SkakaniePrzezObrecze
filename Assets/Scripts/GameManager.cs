using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementEnum { LeftRight, UpDown, SimpleX, SimpleCircle }

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Movement movement;
    [SerializeField]
    private MapController mapController;

    private float TimeCache { get; set; }
    private Controls Controls { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        Controls = new Controls();
        Controls.Enable();
        Controls.player.jump.started += OnSpaceClicked;
        mapController.StartGame();
    }

    private void OnDisable()
    {
        Controls.player.jump.started -= OnSpaceClicked;
        Controls.Disable();
    }

    public void OnSpaceClicked(UnityEngine.InputSystem.InputAction.CallbackContext contex)
    {
        if (TimeCache - Time.unscaledTime < -1f)
        {
            TimeCache = Time.unscaledTime;
            movement.Jump();
            mapController.MapUpdate();
        }
    }
}
