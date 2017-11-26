using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float walkSlow = 2f;
    public float walkFast = 6f;
    public float jumpHeight = 1;
    public float TurnSmoothTime = .1f;
    float TurnVelocity;
    public float SpeedSmoothTime=.1f;
    float SpeedSmoothVelocity;
    float CurrentSpeed;
    public float gravity = -12;
    float VelocityY;
    Animator anim;

    Transform CamT;
    CharacterController controller;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        CamT = Camera.main.transform;
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 Direction = input.normalized;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Direction != Vector2.zero)
        {
            float TargetRot = ((Mathf.Atan2(Direction.x, Direction.y)+Mathf.Tan(90))/(1- (Mathf.Atan2(Direction.x, Direction.y)* Mathf.Tan(90)))) * Mathf.Rad2Deg+ CamT.eulerAngles.y;
            // comme j'ai un probleme j'ai dû utiliser la formule tang(A+B) pour additionner 90 tang(A+B) = (tan(A)+tan(B))/(1-tang(A)*tang(B))
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y,TargetRot,ref TurnVelocity,TurnSmoothTime);

        }
        bool WalkinningSlow = Input.GetKey(KeyCode.LeftShift);
        float TrajetSpeed = ((WalkinningSlow) ? walkSlow : walkFast)*Direction.magnitude;
        CurrentSpeed = Mathf.SmoothDamp(CurrentSpeed, TrajetSpeed, ref SpeedSmoothVelocity, SpeedSmoothTime);

        VelocityY += gravity*Time.deltaTime;
        Vector3 Velocity = transform.right * CurrentSpeed+Vector3.up*VelocityY; // attention forward remplacé par right car j'ai travailler différemment dans
        if (controller.isGrounded)
        {
            //anim.SetLayerWeight(1, 0);
            //VelocityY = 0;
        }
        controller.Move(Velocity*Time.deltaTime);
        CurrentSpeed = new Vector2(controller.velocity.x, controller.velocity.z).magnitude;
        // le programme blender ( soucis d'axes réglés :))
        float SpeedAnim = ((WalkinningSlow) ? CurrentSpeed / 0.2f : CurrentSpeed / 0.5f) * 0.5f;//Direction.magnitude;
        anim.SetFloat("Speed", SpeedAnim,SpeedSmoothTime,Time.deltaTime);
        //Debug.Log("Y "+VelocityY);
        //Debug.Log("Speed" + Velocity.magnitude);
	}
    void Jump()
    {
        if (controller.isGrounded)
        {
            //anim.SetLayerWeight(1,1);
            //anim.SetFloat("Speed", 3f);
            VelocityY = Mathf.Sqrt(-jumpHeight * gravity * 2);
        }
    }
}
