using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Click : MonoBehaviour {
	public int scene = -1;
	bool flag = false;
	void OnMouseDown() {
		flag = true;
	}
	void OnMouseUp() {
		if (flag) {
			SceneManager.LoadScene(scene);
		}
	}
}