using UnityEngine;
using System.Collections;

public class RigidbodySample : MonoBehaviour {

	private Rigidbody rb;
	private float power = 10.0f;

	void Start () {
		
		// 必ずゲームオブジェクトにRigidbodyをつけ、getcomponentする。
		rb = this.GetComponent<Rigidbody> ();
	}

	void Update () {
		
		rb.AddForce (new Vector3 (power, 0, 0)); // Updateごとにpower分のちからを加える。

		rb.AddTorque (new Vector3 (power, 0, 0)); // Updateごとにpower分の回転を加える
	}
}
