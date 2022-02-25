using UnityEngine;

public class Pipes : MonoBehaviour {
    // Refrence the speed at which the pipes move
    public float speed = 5f;
    // Refrences the left most edge of the game 
    private float leftEdge;

// Gets the left edge at the start of the game
    private void Start() {
        // Refrences the camera. And gets the position at which the left edge is.
        // Subtracting 1f to make sure the pipes are off screen when they are destroyed.
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    private void Update() {
        // Moves the pipe on the screen the the left
        transform.position += Vector3.left * speed * Time.deltaTime;
        // Destroys the pipe when the pipe exits the screen
        if(transform.position.x < leftEdge){
            Destroy(gameObject);
        }
    }
}
