using UnityEngine;
using UnityEngine.UI;

public class ScrollingBackground : MonoBehaviour {
    
    
    [SerializeField] private RawImage rawImage;
    private Rect uvRect;

    public float scrollSpeed;
    private int xDir;
    private int yDir;

    void Start() {
        uvRect = rawImage.uvRect;
        xDir = Random.Range(-1, 2);
        yDir = Random.Range(-1, 2);
    }

    void Update() {
        uvRect.x += (scrollSpeed * xDir) * Time.deltaTime;
        uvRect.y += (scrollSpeed * yDir) * Time.deltaTime;
        rawImage.uvRect = uvRect;
    }

}
