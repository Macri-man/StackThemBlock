using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

using UnityEngine.XR; 
using UnityEngine.SpatialTracking; 

public class VRController:MonoBehaviour {


  public XRNode nodetype; 
  public TrackedPoseDriver driver = null; 
  public GameObject visual = null; 
  // Start is called before the first frame update
  void Start() {
    if (driver == null) {
      driver = GetComponent < TrackedPoseDriver > (); 
    }
    driver.trackingType = TrackedPoseDriver.TrackingType.RotationAndPosition; 
  }

  // Update is called once per frame
  void Update() {

    List < XRNodeState > VRStates = new List < XRNodeState > (); 
    InputTracking.GetNodeStates(VRStates); 

    bool setActive = false; 
    foreach (XRNodeState state in VRStates) {
      //if (state.nodeType == nodeType) {
      //  setActive = true; 
      //}
    }
    visual.SetActive(setActive); 
    }
}
