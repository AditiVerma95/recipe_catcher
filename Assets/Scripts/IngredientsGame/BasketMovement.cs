using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public GameObject basket;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update() {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(PlayerInput.Instance.mousePos);
        basket.transform.position = new Vector3(Mathf.Clamp(worldPos.x, -7.6f, 2.67f), basket.transform.position.y, 0f);
    }
}
