using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour // Move GameObjet smoothly from one point to another by mouse click.
{
    public GameObject targetObj;
    Vector3 targetPos; // here we store the position of a targetObj.
    float targetHeight; // it is use for store the y position value of targrtObj.

    private void Start()
    {
         targetPos = targetObj.transform.position;
        targetHeight = targetObj.GetComponent<MeshRenderer>().bounds.size.y;
        //It is use for store gameObject Height means y-Pos value of a targetObj;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100));

            Vector3 direction = mousePos - Camera.main.transform.position;

            RaycastHit hit;

            if(Physics.Raycast(Camera.main.transform.position,direction,out hit, 100))
            {
                if(hit.collider.gameObject.tag=="Plane") // it checks mouse hit on plane or not
                targetPos = hit.point + new Vector3(0, targetHeight / 2f, 0);
                //Here targetHeight is double the actul height of a targetObj;
            }
        }

        targetObj.transform.position = Vector3.MoveTowards(targetObj.transform.position, targetPos, 5f * Time.deltaTime);
        //It is use for move targetObj smoothly from One Point to Another;

    }

}
