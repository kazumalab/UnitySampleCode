using UnityEngine;
using System.Collections;

public class TransformSample : MonoBehaviour {

	void Update () {
		// InputSample.csと組み合わせる
		float dx = Input.GetAxis("Horizontal");
		float dz = Input.GetAxis ("Vertical");

		// キーボードの入力に合わせて移動
		this.transform.position = new Vector3 (this.transform.position.x + dx, this.transform.position.y, this.transform.position.z + dz);

		this.transform.Translate (new Vector3 (this.transform.position.x + dx, this.transform.position.y, this.transform.position.z + dz));

		// キーボードの入力に合わせて回転
		this.transform.rotation = Quaternion.Euler (this.transform.position.x + dx, this.transform.position.y, this.transform.position.z + dz);

		this.transform.Rotate (new Vector3 (this.transform.position.x + dx, this.transform.position.y, this.transform.position.z + dz));

	}
}
