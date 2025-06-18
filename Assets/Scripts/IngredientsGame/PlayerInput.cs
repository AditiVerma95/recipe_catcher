using UnityEngine;

public class PlayerInput : MonoBehaviour {
    public static PlayerInput Instance;
    public UserInput actionMap;
    public Vector2 mousePos;
    private void Awake() {
        Instance = this;
        actionMap = new UserInput();
    }
    void Start()
    {
        
    }
    
    private void OnEnable() {
        actionMap.Player.Enable();
        actionMap.Player.Pos.performed += context => mousePos = context.ReadValue<Vector2>();
        actionMap.Player.Pos.canceled += context => mousePos = Vector2.zero;
        
    }
    private void OnDisable() {
        actionMap.Player.Disable();
    }

   
}
