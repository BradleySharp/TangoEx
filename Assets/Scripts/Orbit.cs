using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float OrbitDegrees;
    public float OrbitDegreesX;
    public float OrbitDegreeZ;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = RotatePointAroundPivot(transform.position, transform.parent.position, Quaternion.Euler(OrbitDegreesX, OrbitDegrees * Time.deltaTime, OrbitDegreeZ));
    }

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }

    /*  void FixedUpdate()
      {
          Vector3 diff = sphere.transomform.position - object.transform.position;
          Vector3 direction = diff.normalized;
          float gravitationalForce = (sphere.mass * object.mass * gravitationalConstant) / diff.sqrMagnitude;
          object.rigidBody.addForce(direction * gravitationalForce);
      }*/
}
