using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour {
	int cntr = 0;
	void Update () {
		transform.Translate(Input.acceleration.x, Input.acceleration.y, 0f);
		transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -6.35f, 6.35f), Mathf.Clamp(transform.position.y, -4.75f, 4.75f), 0);
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "pimple") {
			Destroy(col.gameObject);
			cntr++;
			if (cntr == 10) {
				SceneManager.LoadScene(4);
			}
		}
	}
}