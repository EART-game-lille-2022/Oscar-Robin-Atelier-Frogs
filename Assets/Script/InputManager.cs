using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    #region Events
    public delegate void StartTouch(Vector2 position, float time);
    public event StartTouch OnStartTouch;
    public delegate void EndTouch(Vector2 position, float time);
    public event EndTouch OnEndTouch;   
    #endregion
    private PlayerControllers playersControllers;
    private Camera mainCamera;
    private void Awake() 
    {
        playersControllers = new PlayerControllers();
        mainCamera = Camera.main;
    }
    private void OnEnable() 
    {
        playersControllers.Enable();
    }
    
    private void OnDisable() 
    {
        playersControllers.Disable();
    }
    private void Start() 
    {
        playersControllers.Touch.PrimaryContact.started += ctx => StartTouchPrimary(ctx);
        playersControllers.Touch.PrimaryContact.started += ctx => EndTouchPrimary(ctx);

    }  
    private void StartTouchPrimary(InputAction.CallbackContext context)
    {
        if(OnStartTouch != null ) OnStartTouch(Utils.ScreenToWorld(mainCamera, playersControllers.Touch.PrimaryPosition.ReadValue<Vector2>()),(float)context.startTime);
    }
    private void EndTouchPrimary(InputAction.CallbackContext context)
    {
        if(OnEndTouch != null ) OnEndTouch(Utils.ScreenToWorld(mainCamera, playersControllers.Touch.PrimaryPosition.ReadValue<Vector2>()),(float)context.time);
    }
    public Vector2 PrimaryPosition()
    {
        return Utils.ScreenToWorld(mainCamera, playersControllers.Touch.PrimaryPosition.ReadValue<Vector2>());
    }
}
