using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanControl : MonoBehaviour
{
    // 
    private CharacterController UnityChan;
    // 
    private Vector3 moveDirection = Vector3.zero;
    // 
    private float StartGameTimer;

    // 
    public GameObject MainCamera;
    // 
    private Vector3 UnityChanPosition;
    // 
    private Vector3 CameraFollowVector;

    // 
    private bool StartGameBool;
    // 
    public float RunSpeed;
    // 
    public float JumpSpeed;
    // 
    public float Gravity;

    // 初始化設定
    void Start()
    {
        // 
        UnityChan = this.GetComponent<CharacterController>();
        // 
        this.GetComponent<AnimControl>().RunBool = false;
        // 
        this.GetComponent<AnimControl>().JumpBool = false;

        // 
        StartGameBool = false;
        // 
        StartGameTimer = 0;

    }

    // 持續執行
    void Update()
    {
        // 
        if (StartGameBool == true) {
            // 
            if (UnityChan.isGrounded) {
                // 
                moveDirection = new Vector3(0, 0, 1);
                moveDirection = transform.TransformDirection(moveDirection);
                // 
                this.GetComponent<AnimControl>().JumpBool = false;
                // 
                if (Input.GetKeyDown(KeyCode.Space)) {
                    // 
                    moveDirection = new Vector3(0, JumpSpeed, 1);
                    moveDirection = transform.TransformDirection(moveDirection);
                    // 
                    this.GetComponent<AnimControl>().JumpBool = true;

                }
                // 
                moveDirection *= RunSpeed;

            }
        }
        else {
            // 
            // 
            StartGameTimer += Time.deltaTime;
            // 
            if (StartGameTimer >= 1) {
                // 
                StartGameBool = true;
                // 
                StartGameTimer = 0;
                // 
                this.GetComponent<AnimControl>().RunBool = true;
            }
        }
        // 
        moveDirection.y -= Gravity * Time.deltaTime;
        // 
        UnityChan.Move(moveDirection*Time.deltaTime);
        // 
        UnityChanPosition = this.GetComponent<Transform>().position;
        // 
        CameraFollowVector =new Vector3(UnityChanPosition.x, 1.6f, UnityChanPosition.z - 1.2f);
        // 
        MainCamera.GetComponent<Transform>().position = CameraFollowVector;
    }
}
