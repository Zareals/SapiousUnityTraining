using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PllayerController : MonoBehaviour
{
    public int moveSpeed;

    void Update()
    {
        MovementInput();
        RotationInput();
    }

    public void MovementInput()
    {
        float horizantal = Input.GetAxis("Horizontal"); // 1 or -1
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizantal, 0, vertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }

    public void RotationInput()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
}
