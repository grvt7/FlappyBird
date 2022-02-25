using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    // Refrences the Player
    public Player player;
    // Refrence to the score text on the screen
    public Text scoreText;
    // Refrences the play object->Text and Buttons
    public GameObject playButton;
    // Refrences the game over object->text (can be more)
    public GameObject gameOver;
    // Refrences the Score
    private int score;

// First function to run
    private void Awake() {
        // Sets the framerate to 60. Wont go over it.
        Application.targetFrameRate = 60;
        // Calls Pause Function.
        Pause();
    }

    public void Play() {
        // Resets score to 0
        score = 0;
        // Updates score text
        scoreText.text = score.ToString();
        // Sets play button to hide
        playButton.SetActive(false);
        // Hides game over text
        gameOver.SetActive(false);
        // Resets the time scale to 1 i.e. moving and updating
        Time.timeScale = 1f;
        // Enables the player
        player.enabled = true;

        // Refrences all the pipes on the screen or in the pipes game object
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        // Loops the the pipes
        for(int i=0; i<pipes.Length; i++) {
            // Destroys the individual pipes and their game objects
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause() {
        // Sets the time scale to 0 i.e. time wont update
        Time.timeScale = 0f;
        // Disable the player as the player looks for input.
        player.enabled = false;
    }

    public void GameOver() {
        // Displays the text when the function is called
        gameOver.SetActive(true);
        // Same as above
        playButton.SetActive(true);
        // Pauses the game when game ends
        Pause();
    }

    public void IncreseScore() {
        // Increses score
        score++;
        // Displays the updated score
        scoreText.text = score.ToString();
    }
}
