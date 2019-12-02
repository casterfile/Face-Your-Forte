using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Swipe : MonoBehaviour {
	float mouseDownPosX = 0f, mouseUpPosX = 0f;
	public int prev = -1;
	public int next = -1;
	void OnMouseDown() {
		mouseDownPosX = Input.mousePosition.x;
	}
	void OnMouseUp() {
		mouseUpPosX = Input.mousePosition.x;
		if (mouseDownPosX > mouseUpPosX + 100f) {
			try {
				SceneManager.LoadScene(next);
			} catch {

			}
		} else if (mouseUpPosX > mouseDownPosX + 100f) {
			try {
				SceneManager.LoadScene(prev);
			} catch {

			}
		} else {
			mouseDownPosX = 0f;
			mouseUpPosX = 0f;
		}
	}
}