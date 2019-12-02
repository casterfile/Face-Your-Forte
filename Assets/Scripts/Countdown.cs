using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Countdown : MonoBehaviour {
	int sec = 10;
	void Start() {
		InvokeRepeating("DecreaseSec", 1f, 1f);
	}
	void DecreaseSec() {
		if (sec > 0) {
			sec--;
			if (sec > 9)
				GetComponent<Text>().text = "0:" + sec;
			else
				GetComponent<Text>().text = "0:0" + sec;
		} else
			SceneManager.LoadScene(3);
	}
}