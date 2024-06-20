using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float rightOrLeftSpeed = 4;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed,Space.World); //this movement relative the world.
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * rightOrLeftSpeed);
            }
            
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * rightOrLeftSpeed * -1);
            }
            
        }
        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
            playerObject.GetComponent<Animator>().Play("Jumping");
            StartCoroutine(JumpSequence());
        }
        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3,Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }
    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        comingDown = false;
        isJumping = false;
        playerObject.GetComponent<Animator>().Play("Standard Run");
    }
}
