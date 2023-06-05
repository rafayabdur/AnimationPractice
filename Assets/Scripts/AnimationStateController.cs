using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator _animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float decceleration = 0.5f;
    int VelocityHash;
    
    // Start is called before the first frame update
    void Start()
    {
        
       _animator = GetComponent<Animator>();
       VelocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {
        bool ForwardPress = Input.GetKey("w");
        bool RunPress = Input.GetKey("s");
        


        if (ForwardPress && velocity < 1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (!ForwardPress && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * decceleration;
        }

        if (!ForwardPress && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        _animator.SetFloat(VelocityHash,velocity);
        
    }
}
