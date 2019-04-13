using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	bool gamehasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive (true);
	}

	public void EndGame()
	{
		if (gamehasEnded == false) {
			gamehasEnded = true;
			Debug.Log ("Game Over");
			Invoke ("Restart", restartDelay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
