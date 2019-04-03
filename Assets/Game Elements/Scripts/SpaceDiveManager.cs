﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDiveManager : MonoBehaviour {

    string[] Planets = { "instructions", "mercury", "venus", "mars", "jupiter", "saturn", "uranus", "neptune" };
    public GameObject[] NavigationUI = new GameObject[7]; 
    int PlanetsIndex = 0;
    public GameObject NavigationUI_forward, NavigationUI__backward;
    bool ActiveAnimation, VisibileNavigationUI;
    //public Transform target=null;
    public bool moving = false;
    private Vector3 velocity = Vector3.zero;
    //public Animation mercury_venus;
    public Animator GVREmulatorAnimator;
    /*
    private void Update()
    {
        if (AnimatorIsPlaying(GVREmulatorAnimator))
        {
            ActiveAnimation = true;
        }
        else
        {
            ActiveAnimation = false;
        }

        if(PlanetsIndex != 0 && !ActiveAnimation && !VisibileNavigationUI)
        {
            if (PlanetsIndex == 1)
            {
                NavigationUI_forward.SetActive(true);
            }
            if(PlanetsIndex == 7)
            {
                NavigationUI__backward.SetActive(true);
            }
            else
            {
                NavigationUI_forward.SetActive(true);
                NavigationUI__backward.SetActive(true);
            }
        }

        if(ActiveAnimation && VisibileNavigationUI)
        {
            NavigationUI_forward.SetActive(false);
            NavigationUI__backward.SetActive(false);
        }
    }
    /* void Awake()
     {
         DontDestroyOnLoad(GVREmulator);
     }

 // Use this for initialization
 void Start () {

     }

     // Update is called once per frame
     /*void Update () {

         if (moving && target!=null)
         {
             Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0, 0));
             GVREmulator.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.3f);
         }

     }

     public void goToPlanet(string planet)
     {
         Debug.Log("inside goToplanet");
         Debug.Log("recieved string: "+planet);
         switch (planet)
         {
             case "mercury":
                 Smooth_move(mercury, 5.0f);
                 break;
             case "venus":
                 Debug.Log("inside venus case");
                 //GVREmulator.transform.SetParent(venus.transform);
                 target = venus.transform;
                 moving = true;
                 TestMove(venus);
                 //StartCoroutine(Smooth_move(venus, 5.0f));
                 Debug.Log("after method call");
                 break;
             case "earth":
                 Smooth_move(earth, 5.0f);
                 break;
             case "mars":
                 Smooth_move(mars, 5.0f);
                 break;
             case "jupiter":
                 Smooth_move(jupiter, 5.0f);
                 break;
             case " saturn":
                 Smooth_move(saturn, 5.0f);
                 break;
             case " neptune":
                 Smooth_move(neptune, 5.0f);
                 break;

         }
     }

     IEnumerator Smooth_move(GameObject goToPosition, float speed)
     {

         float startime = Time.time;
         Vector3 direction = goToPosition.transform.position;
          Vector3 start_pos = GVREmulator.transform.position; //Starting position.
          Vector3 end_pos = goToPosition.transform.position+direction; //Ending position.
          Quaternion rotationDirection = goToPosition.transform.rotation;
          Quaternion start_rot = GVREmulator.transform.rotation;
         // Quaternion end_rot = goToPosition.transform.rotation + rotationDirection;
         Debug.Log(start_pos != end_pos) ;
         float i = (Time.time - startime) *speed;
         Debug.Log("time: "+i);
         while (start_pos != end_pos && ((Time.time - startime) * speed) < 1f)
         {
             Debug.Log("inside loop");
             float move = Mathf.Lerp(0, 1, (Time.time - startime) * speed);

             GVREmulator.transform.position += direction * move;

             yield return null;
         }
     }

     public void TestMove(GameObject planet)
     {
          Debug.Log("inside test move");
          GVREmulator.transform.SetParent(planet.transform);
         Vector3 currentPosition = GVREmulator.transform.localPosition;
         Vector3 endPosition = new Vector3(0, 0, 0);
         /*GVREmulator.transform.rotation = new Quaternion(0, 0, 0, 0);
         GVREmulator.transform.localPosition = new Vector3(0, 0, 0);
         //transform.position = Vector3.(currentPosition, endPosition, Time.deltaTime);
     }
     */
    /* public void PlayAnimation(bool forward)
    {
       int x;
        if (forward)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        string triggerName = Planets[PlanetsIndex] + "-"+ Planets[PlanetsIndex+x];
        GVREmulatorAnimator.SetBool(triggerName, true);
        PlanetsIndex += x;
}

bool AnimatorIsPlaying(Animator animator)
    {
        return animator.GetCurrentAnimatorStateInfo(0).length >
               animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }*/

    public void PlayAnimation(string triggerName)
    {
        GVREmulatorAnimator.SetBool(triggerName, true);
    }
}
