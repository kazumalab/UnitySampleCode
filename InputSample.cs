using UnityEngine;
using System.Collections;

public class InputSample : MonoBehaviour {

	void Update () {

		if (Input.GetMouseButton (0)) { // 0は左クリック時 
			// 処理
		}

		if (Input.GetMouseButton (1)) { // 1は右クリック時
			// 処理
		}
			
		if (Input.GetMouseButtonDown (0)) { // 左クリックした時
			// 処理
		}

		if (Input.GetMouseButtonUp (0)) { // 左クリックを離した時
			// 処理
		}

		float dx = Input.GetAxis ("Horizontal"); // キーボードの左右
		float dy = Input.GetAxis ("Vertical"); // キーボードの上下

		Vector2 InputPosition = Input.mousePosition; // クリックした場所を取得

	}
}
