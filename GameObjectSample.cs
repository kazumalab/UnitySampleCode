using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameObjectSample : MonoBehaviour {

	public GameObject sampleObject; // prefab化したものをinspectorで入れておく。

	private Button localButton;

	// Use this for initialization
	void Start () {
		GameObject obj1 = Instantiate(sampleObject); // ゲーム上に生成（sampleObjectの位置）
		GameObject obj2 = (GameObject) Instantiate(sampleObject, Vector3.zero, Quaternion.identity); // 生成位置と角度を引数で指定できる。

		localButton = sampleObject.GetComponent<Button> (); // ButtonのComponentをGetする。
		localButton.enabled = true;

	}
}
