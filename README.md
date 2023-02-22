# SensorLogger


## Usage
### step1
- use the `Device Logs` function in Meta Quest Developer Hub and filter with "Device",  
or
- use `adb logcat | grep Device > log.txt` to collect the log to a local file.

### step2
- run this program on the headset.


## Log sample:
```py
17:26:40.822 Unity Device Oculus Touch Controller - Right's feature IndexTouch's value is False
17:26:40.822 Unity Device Oculus Touch Controller - Right's feature ThumbTouch's value is False
17:26:40.822 Unity Device Oculus Touch Controller - Right's feature Primary2DAxisClick's value is False
17:26:40.822 Unity Device Oculus Touch Controller - Right's feature Primary2DAxisTouch's value is False
17:26:40.822 Unity Device Oculus Touch Controller - Right's feature Thumbrest's value is False
17:26:40.823 Unity Device Oculus Touch Controller - Right's feature IsTracked's value is False
17:26:40.823 Unity Device Oculus Touch Controller - Right's UNTRACKED feature TrackingState's type is System.UInt32
17:26:40.823 Unity Device Oculus Touch Controller - Right's feature DevicePosition's value is (0.00, 1.68, -0.07)
17:26:40.823 Unity Device Oculus Touch Controller - Right's feature DeviceRotation's value is (0.00000, -0.00844, 0.00000, 0.99996)
17:26:40.823 Unity Device Oculus Touch Controller - Right's feature DeviceVelocity's value is (0.00, 0.00, 0.00)
17:26:40.824 Unity Device Oculus Touch Controller - Right's feature DeviceAngularVelocity's value is (0.00, 0.00, 0.00)
17:26:40.824 Unity Device Oculus Touch Controller - Right's feature DeviceAcceleration's value is (0.00, 0.00, 0.00)
17:26:40.824 Unity Device Oculus Touch Controller - Right's feature DeviceAngularAcceleration's value is (0.00, 0.00, 0.00)
17:26:40.826 Unity Device found with name 'Oculus Quest' and role 'Generic'
17:26:40.826 Unity Device Oculus Quest's feature UserPresence's value is True
17:26:40.827 Unity Device Oculus Quest's feature IsTracked's value is True
17:26:40.827 Unity Device Oculus Quest's UNTRACKED feature TrackingState's type is System.UInt32
17:26:40.827 Unity Device Oculus Quest's feature DevicePosition's value is (0.08, 1.54, 0.38)
17:26:40.827 Unity Device Oculus Quest's feature DeviceRotation's value is (0.00023, 0.33867, -0.00036, 0.94091)
17:26:40.827 Unity Device Oculus Quest's feature DeviceVelocity's value is (0.00, 0.00, 0.00)
17:26:40.828 Unity Device Oculus Quest's feature DeviceAngularVelocity's value is (0.00, 0.00, 0.00)
17:26:40.828 Unity Device Oculus Quest's feature DeviceAcceleration's value is (0.00, 0.00, 0.00)
17:26:40.828 Unity Device Oculus Quest's feature DeviceAngularAcceleration's value is (0.00, 0.00, 0.00)
17:26:40.828 Unity Device Oculus Quest's feature LeftEyePosition's value is (0.06, 1.54, 0.40)
```
