using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class RotateToTrail : MonoBehaviour
{

    [SerializeField] private TrailRenderer trailRenderer;
    public void Update()
    {
        if(trailRenderer.positionCount <= 0) return;
      var p1 =  trailRenderer.GetPosition(trailRenderer.positionCount-2);
      var p2 =  trailRenderer.GetPosition(trailRenderer.positionCount-1);
      var diff = p2 - p1;
      
      float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
      var rot = Quaternion.Euler(0f, 0f, rot_z - 90);
      transform.rotation = Quaternion.Slerp(transform.rotation,rot,0.3f);

    }

}
