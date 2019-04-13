using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rb;
	public float Forwardforce = 1000f;
	public float Sidewayforce = 500f;

	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce (0, 0, Forwardforce * Time.deltaTime);

		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.position.x > (Screen.width / 2))
			{
				rb.AddForce (Sidewayforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
			if (touch.position.x < (Screen.width / 2))
			{
				rb.AddForce (-Sidewayforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
		}

		if (Input.GetKey ("d")) 
		{
			rb.AddForce (Sidewayforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey ("a")) 
		{
			rb.AddForce (-Sidewayforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

}
