using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float Sensivity = 1.0f;


    private DefaultPlayerControl mDefaultPlayerControl;

    private void Awake()
    {
        mDefaultPlayerControl = new DefaultPlayerControl();
    }

    private void OnEnable()
    {
        mDefaultPlayerControl.PlayerControl.Move.Enable();
        mDefaultPlayerControl.PlayerControl.Look.Enable();
        mDefaultPlayerControl.PlayerControl.Jump.Enable();
    }

    private void OnDisable()
    {
        mDefaultPlayerControl.PlayerControl.Move.Disable();
        mDefaultPlayerControl.PlayerControl.Look.Disable();
        mDefaultPlayerControl.PlayerControl.Jump.Disable();
    }
}
