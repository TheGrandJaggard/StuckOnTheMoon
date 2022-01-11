using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
	[Range(1, 50)] [SerializeField] private int m_JumpForce;                    // Amount of force added when the player jumps.
	[Range(0, 2)] [SerializeField] private float m_CrouchSpeed = .4f;           // Amount of maxSpeed applied to crouching movement. 1 = 100%
	[Range(0, 0.3f)] [SerializeField] private float m_MovementSmoothing = .05f; // How much to smooth out the movement
	[SerializeField] private LayerMask m_WhatIsGround;                          // A mask determining what is ground to the character
	[SerializeField] private Transform m_GroundCheck;                           // A position marking where to check if the player is grounded.
	[SerializeField] private Transform m_CeilingCheck;                          // A position marking where to check for ceilings
	[SerializeField] private Collider2D m_CrouchDisableCollider;                // A collider that will be disabled when crouching
	[SerializeField] private Collider2D m_CrouchEnableCollider;                 // A collider that will be enabled when crouching

	const float k_GroundedRadius = 0.1f; // Radius of the overlap circle to determine if grounded
	private bool m_Grounded;            // Whether or not the player is grounded.
	const float k_CeilingRadius = 0.1f;  // Radius of the overlap circle to determine if the player can stand up
	private Rigidbody2D m_Rigidbody2D;
	private bool m_FacingRight = true;  // For determining which way the player is currently facing.
	private Vector3 m_Velocity = Vector3.zero;

	public Animator Animator;
	public GameObject ArmObject;
	private Transform ArmTransform;
	private Vector3 MousePos;
	private Vector2 GunVector;
	private bool CanJump = true;

	private AudioSource PlayerAudio;
	public AudioClip Landing;
	public AudioClip Step1;
	public AudioClip Step2;

	private bool PlayStep1Next = true;
	private int MakeStepNoise;

	//public UnityEvent OnLandEvent;

	private bool m_wasCrouching = false;

	public bool CanControl = true;
	public float RunSpeed = 40f;
	private float Movement;
	private bool Jump = false;
	private bool Crouch = false;
	public float TimeBetweenJumps;
	private bool AmCrouching;
	private bool WasCrouching;


	private void Awake()
	{
		ArmTransform = ArmObject.transform;
		PlayerAudio = GetComponent<AudioSource>();
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
		Animator = GetComponent<Animator>();

		//if (OnLandEvent == null)
		//	OnLandEvent = new UnityEvent();

	}

	void OnStartJumping()
	{
		Jump = true;
	}

	void OnStopJumping()
	{
		Jump = false;
	}

	void OnStartCrouching()
	{
		Crouch = true;
	}

	void OnStopCrouching()
	{
		Crouch = false;
	}

	public void OnMove(InputValue input)
	{
		Movement = input.Get<float>() * RunSpeed;
	}


	private void FixedUpdate()
	{
		Animator.SetFloat("Speed", Mathf.Abs(Movement));

		Move(Movement * Time.fixedDeltaTime, Crouch, Jump);

		MakeStepNoise += 1;
		if (m_Grounded == true && Movement != 0 && MakeStepNoise > 10 && !AmCrouching)
		{
			if (PlayStep1Next == true)
			{
				PlayerAudio.clip = Step1;
				PlayerAudio.Play();
				PlayStep1Next = false;
				MakeStepNoise = 0;
			}
			else
			{
				PlayerAudio.clip = Step2;
				PlayerAudio.Play();
				PlayStep1Next = true;
				MakeStepNoise = 0;
			}
		}

		bool wasGrounded = m_Grounded;
		m_Grounded = false;

		MousePos = Mouse.current.position.ReadValue();
		MousePos.z = 10;
		MousePos = Camera.main.ScreenToWorldPoint(MousePos);
		Vector2 Direction = new Vector2(MousePos.x - ArmTransform.position.x, MousePos.y - ArmTransform.position.y);
		ArmTransform.right = Direction;
		
		if (Direction.x <= 0f)
        {
			ArmTransform.transform.eulerAngles = new Vector3(
				ArmTransform.transform.eulerAngles.x + 180,
				ArmTransform.transform.eulerAngles.y,
				-ArmTransform.transform.eulerAngles.z
			);
		}

		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
		// This can be done using layers instead but Sample Assets will not overwrite your project settings.
		Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
			{
				m_Grounded = true;
				if (!wasGrounded)
				{
					//OnLandEvent.Invoke();

					PlayerAudio.clip = Landing;
					PlayerAudio.Play();
				}
			}
		}

		Animator.SetBool("Crouching", m_wasCrouching);
		Animator.SetBool("Jumping", !m_Grounded);
	}


	public void Move(float move, bool WantToCrouch, bool WantToJump)
	{
		if (!Physics2D.OverlapCircle(m_CeilingCheck.position, k_CeilingRadius, m_WhatIsGround))
		{
			WasCrouching = false;
		}

		// If crouching, check to see if the character can stand up
		if (WantToCrouch)
		{
			AmCrouching = true;
			WasCrouching = true;
		}
        else
		{
			// If the character has a ceiling preventing them from standing up, keep them crouching
			if (Physics2D.OverlapCircle(m_CeilingCheck.position, k_CeilingRadius, m_WhatIsGround)
				&& WasCrouching)
			{
				AmCrouching = true;
			}
            else
            {
				AmCrouching = false;
			}
		}

		//only control the player if grounded or airControl is turned on
		if (CanControl)
		{
			
			// If crouching
			if (AmCrouching)
			{
				if (!m_wasCrouching)
				{
					m_wasCrouching = true;
					ArmObject.SetActive(false);
					CanJump = false;
				}

				// Reduce the speed by the crouchSpeed multiplier
				move *= m_CrouchSpeed;

				// Disable one of the colliders when crouching
				if (m_CrouchDisableCollider != null)
				{
					m_CrouchDisableCollider.enabled = false;
					m_CrouchEnableCollider.enabled = true;
				}
			}
			else
			{
				// Enable the collider when not crouching
				if (m_CrouchDisableCollider != null)
				{
					m_CrouchDisableCollider.enabled = true;
					m_CrouchEnableCollider.enabled = false;
				}

				if (m_wasCrouching)
				{
					m_wasCrouching = false;
					ArmObject.SetActive(true);
					CanJump = true;
				}
			}

			// Move the character by finding the target velocity
			Vector3 targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
			// And then smoothing it out and applying it to the character
			m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);

			// If the input is moving the player right and the player is facing left...
			if (move > 0 && !m_FacingRight)
			{
				// ... flip the player.
				Flip();
			}
			// Otherwise if the input is moving the player left and the player is facing right...
			else if (move < 0 && m_FacingRight)
			{
				// ... flip the player.
				Flip();
			}
		}
		// If the player should jump...

		if (m_Grounded && WantToJump && CanJump)
		{
			AddJumpForce(m_JumpForce);
		}
	}

	public void AddJumpForce(int Force)
	{
		// Add a vertical force to the player.

		//Debug.Log("AddForce... " + Force.ToString());
		m_Rigidbody2D.AddForce(new Vector2(0, Force * 100));

		CanJump = false;
		Invoke("SetCanJump", TimeBetweenJumps);
	}

	void SetCanJump()
	{
		CanJump = true;
	}

	private void Flip()
	{
		// Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;
		transform.Rotate(0f, 180f, 0f);
	}
}