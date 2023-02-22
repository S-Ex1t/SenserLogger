using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.Events;
public class sensorlogger : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        Debug.Log("Sensor loging!!");
    }
    
    // Update is called once per frame
    void Update()
    {
        var inputDevices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(inputDevices);

        foreach (var device in inputDevices)
        {
            Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));
            var inputFeatures = new List<UnityEngine.XR.InputFeatureUsage>();
            if (device.TryGetFeatureUsages(inputFeatures))
            {
                foreach (var feature in inputFeatures)
                {
                    
                    // Debug.Log(string.Format("Device {2}'s feature {0}'s type is {1}", feature.name, feature.type, device.name));
                    // UnityEngine.Quaternion
                    // System.Boolean
                    // UnityEngine.Vector3
                    // System.UInt32
                    if (feature.type == typeof(bool))
                    {
                        bool featureValue;
                        if (device.TryGetFeatureValue(feature.As<bool>(), out featureValue) )
                        {
                            Debug.Log(string.Format("Device {2}'s feature {0}'s value is {1}", feature.name, featureValue.ToString(), device.name));
                        }
                    }
                    else if (feature.type == typeof(Vector3))
                    {
                        Vector3 featureValue;
                        if (device.TryGetFeatureValue(feature.As<Vector3>(), out featureValue) )
                        {
                            Debug.Log(string.Format("Device {2}'s feature {0}'s value is {1}", feature.name, featureValue.ToString(), device.name));
                        }
                    }else if (feature.type == typeof(Vector2))
                    {
                        Vector2 featureValue;
                        if (device.TryGetFeatureValue(feature.As<Vector2>(), out featureValue) )
                        {
                            Debug.Log(string.Format("Device {2}'s feature {0}'s value is {1}", feature.name, featureValue.ToString(), device.name));
                        }
                    }else if(feature.type == typeof(Quaternion))
                    {
                        Quaternion featureValue;
                        if (device.TryGetFeatureValue(feature.As<Quaternion>(), out featureValue) )
                        {
                            Debug.Log(string.Format("Device {2}'s feature {0}'s value is {1}", feature.name, featureValue.ToString(), device.name));
                        }
                    }else if(feature.type == typeof(float))
                    {
                        float featureValue;
                        if (device.TryGetFeatureValue(feature.As<float>(), out featureValue) )
                        {
                            Debug.Log(string.Format("Device {2}'s feature {0}'s value is {1}", feature.name, featureValue.ToString(), device.name));
                        }
                    }
                    // else if(feature.type == typeof(UInt32))
                    // {
                    //     InputTrackingState featureValue;
                    //     if (device.TryGetFeatureValue(feature.As<InputTrackingState>(), out featureValue) )
                    //     {
                    //         Debug.Log(string.Format("Device {2}'s feature {0}'s value is {1}", feature.name, featureValue.ToString(), device.name));
                    //     }
                    // }
                    else{
                         Debug.Log(string.Format("Device {2}'s UNTRACKED feature {0}'s type is {1}", feature.name, feature.type, device.name));
                    }
                }
            }
        }
        
    }
}
