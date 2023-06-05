using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator _animator;
    int isWalkingHash;
    int isrunningHash;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isrunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPress = Input.GetKey("w");
        bool runPress = Input.GetKey("s");

        bool IsRunning = _animator.GetBool(isrunningHash);
        bool IsWalking = _animator.GetBool(isWalkingHash);


        if ((!IsWalking && forwardPress))
        {
            _animator.SetBool(isWalkingHash, true);
        }
        if ((IsWalking && !forwardPress))
        {
            _animator.SetBool(isWalkingHash, false);
        }
        if (!IsRunning && (forwardPress && runPress))
        {
            _animator.SetBool(isrunningHash, true);
        }
        if (IsRunning && (!forwardPress || !runPress))
        {
            _animator.SetBool(isrunningHash, false);
        } 
        if (runPress  )
        {
            _animator.SetBool(isrunningHash, true);
        }
        if (!runPress)
        {
            _animator.SetBool(isrunningHash, false);
        }
    }
}
