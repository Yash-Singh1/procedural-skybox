using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField] float mouseSensitivity = 5.0f;
	float rotY = 0.0f;
	void Update()
	{
		// rotation
		if(Input.GetMouseButton(1))
		{
			float rotX = transform.eulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity;
			rotY += Input.GetAxis("Mouse Y") * mouseSensitivity;
			rotY = Mathf.Clamp(rotY, -89.5f, 89.5f);
			transform.eulerAngles = new Vector3(-rotY, rotX, 0.0f);
		}
	}
}