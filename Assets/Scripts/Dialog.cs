using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Dialog : MonoBehaviour {

	public DialogNode[] node;
	public int _currentNode;
	public Text text;
	public GameObject DialogWindow;

	public void Switch() {
		if (_currentNode + 1 > node.Length/2) {
			DialogWindow.SetActive(false);
		} 
		else {
			_currentNode += 1;
		}
		text.text = node[_currentNode].NpcText;

	}
	public void Awake() {
		text.text = node[_currentNode].NpcText;
	}
	public void Update() {
		if (Input.GetAxisRaw("Submit") > 0) {
			Switch();
		}
	}
}

[System.Serializable]
public class DialogNode {
	public string NpcText;
}
 
