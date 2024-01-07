using UnityEngine;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float moveHorizontal;
    private float moveVertical;
    private bool canMove = true;
    public List<Transform> restrictedAreas;

    private void Update()
    {
        if (!canMove)
            return;

        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveVertical = 1f;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveVertical = -1f;
        }
        else
        {
            moveVertical = 0f;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = -1f;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = 1f;
        }
        else
        {
            moveHorizontal = 0f;
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        movement.Normalize();

        // 获取角色下一步的位置
        Vector3 nextPosition = transform.position + new Vector3(movement.x, movement.y, 0f) * moveSpeed * Time.deltaTime;

        // 检查下一步的位置是否在任一限制区域内
        foreach (Transform area in restrictedAreas)
        {
            if (area.GetComponent<Collider2D>().bounds.Contains(nextPosition))
            {
                // 如果在限制区域内，不进行移动
                return;
            }
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}