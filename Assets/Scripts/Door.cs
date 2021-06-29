using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : MonoBehaviour
{
    [SerializeField] [Range(0f, 2f)] float SpeedMultiplier = 1f;
    Animator LinkedAnimator;

    // Start is called before the first frame update
    void Start()
    {
        LinkedAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // this would not typically be done in update. placing here so as to demonstrate easily changing while running.
        LinkedAnimator.SetFloat("DoorSpeed", SpeedMultiplier);
    }

    void OnTriggerEnter(Collider other)
    {
        LinkedAnimator.SetTrigger("OpenDoor");
    }

    void OnTriggerExit(Collider other)
    {
        LinkedAnimator.SetTrigger("CloseDoor");
    }

    public void OnDoorOpen()
    {
        Debug.Log("OPEN THE DOOR!");
    }

    public void OnLeftDoorStuck()
    {
        Debug.Log("LEFT DOOR IS STUCK!");
    }
}
