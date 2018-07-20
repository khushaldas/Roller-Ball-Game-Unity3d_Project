using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControl : MonoBehaviour {
	private Rigidbody rb;
	private int count;
	public Text countText; 
	public Text winText;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		countText.text = "Count: " + count.ToString ();
		winText.text = "";

	}
		

	void FixedUpdate () 

	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement*10);

	}
	void OnTriggerEnter(Collider other ){
		if (other.gameObject.CompareTag ("Pick up")) {
			other.gameObject.SetActive (false); 
			count = count + 1; 
			countText.text = "Count: " + count.ToString ();
		}
		if (count >= 14) {
			winText.text = "You are Winner.! ";
		}
	
	}


}
