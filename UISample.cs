using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UISample : MonoBehaviour {

	public Text sampleText;
	public Image sampleImage;
	public Sprite sampleSprite;

	public void OnclickButton () { // 引数なし
		// ボタン押した時の処理
	}

	public void OnClickButton (string name) { // 引数あり
		if (name == "button1") {
			// 引数に応じて処理を変えられる
		}
	}
		
	void Start () {
		
		sampleText.text = "こういう感じで変更できます。"; // Textの変更
		sampleImage.sprite = sampleSprite; // 画像はSpriteというもので変更

		sampleText.enabled = false; // ゲーム画面から非表示
	}

}
