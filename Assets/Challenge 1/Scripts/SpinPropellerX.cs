using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
	private float propellorSpeed = 500; // 1000;
	void Update() {
		transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
	}
}
