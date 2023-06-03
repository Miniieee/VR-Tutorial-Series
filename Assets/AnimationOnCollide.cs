using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnCollide : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool isHit = false;

    private void OnCollisionEnter(Collision other) {

        if (other.gameObject.CompareTag("Bullet"))
        {
            animator.SetTrigger("Hit");
        }
    }
}
