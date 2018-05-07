using UnityEngine;
using System.Collections;
public class Ball : MonoBehaviour {
	//public float horizontalSpeed = 2.0F;
	//public float verticalSpeed = 2.0F;
    public float force;
    private Rigidbody _rigidbody;
    private bool _isGrounded;
	// Use this for initialization
	void Start () {
        _rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//float h = horizontalSpeed * Input.GetAxis("Mouse X");
		//float v = verticalSpeed * Input.GetAxis("Mouse Y");
		//transform.Rotate(v, h, 0);
        if (!_isGrounded) return;
        var vectorForce = Input.GetAxis("Vertical") * Vector3.forward;
        vectorForce += Input.GetAxis("Horizontal") * Vector3.right;
        
        /*Vector3 movement = new Vector3(Input.GetAxis(“Mouse X”), 0.0f, Input.GetAxis(“Mouse Y”));*/

        _rigidbody.AddForce(vectorForce * force);
	}

    void OnTriggerEnter (Collider other)
    {
        _isGrounded = true;
    }

    void OnTriggerExit (Collider other)
    {
       // _isGrounded = false;
    }
}