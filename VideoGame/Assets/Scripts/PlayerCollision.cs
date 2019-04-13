using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public Movement move;
    

	void OnCollisionEnter(Collision collisioninfo)
	{
		if (collisioninfo.collider.tag == "Obstacle") {
            Time.timeScale = 0.8f;
            move.enabled = false;
            

			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

}
