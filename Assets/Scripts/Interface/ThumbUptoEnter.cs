using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Hands.Gestures;
using UnityEngine.SceneManagement;

namespace UnityEngine.XR.Hands.Samples.GestureSample{
    public class ThumbUptoEnter : MonoBehaviour{
        
        [SerializeField]
        [Tooltip("The hand tracking events component to subscribe to receive updated joint data to be used for gesture detection.")]
        XRHandTrackingEvents _HandTrackingEvents;

        [SerializeField]
        [Tooltip("The hand shape or pose that must be detected for the gesture to be performed.")]
        ScriptableObject _HandShapeOrPose;   

        [SerializeField]
        [Tooltip("The event fired when the gesture is performed.")]
        UnityEvent _GesturePerformed;

        [SerializeField]
        [Tooltip("The event fired when the gesture is ended.")]
        UnityEvent _GestureEnded; 

        [SerializeField]
        [Tooltip("The minimum amount of time the hand must be held in the required shape and orientation for the gesture to be performed.")]
        float _MinimumHoldTime = 0.2f;

        [SerializeField]
        [Tooltip("The interval at which the gesture detection is performed.")]
        float _GestureDetectionInterval = 0.1f;

        XRHandShape _HandShape;
        XRHandPose _HandPose;
        bool _WasDetected;
        bool _PerformedTriggered;

        float _TimeOfLastConditionCheck;
        float _HoldStartTime;
    
        /// <summary>
        /// The hand tracking events component to subscribe to receive updated joint data to be used for gesture detection.
        /// </summary>
        public XRHandTrackingEvents handTrackingEvents{
            get => _HandTrackingEvents;
            set => _HandTrackingEvents = value;
        }

        /// <summary>
        /// The hand shape or pose that must be detected for the gesture to be performed.
        /// </summary>
        public ScriptableObject handShapeOrPose{
            get => _HandShapeOrPose;
            set => _HandShapeOrPose = value;
        }

        /// <summary>
        /// The minimum amount of time the hand must be held in the required shape and orientation for the gesture to be performed.
        /// </summary>
        public float minimumHoldTime{
            get => _MinimumHoldTime;
            set => _MinimumHoldTime = value;
        }

        /// <summary>
        /// The interval at which the gesture detection is performed.
        /// </summary>
        public float gestureDetectionInterval{
            get => _GestureDetectionInterval;
            set => _GestureDetectionInterval = value;
        }

        void OnEnable(){
            _HandTrackingEvents.jointsUpdated.AddListener(OnJointsUpdated);

            _HandShape = _HandShapeOrPose as XRHandShape;
            _HandPose = _HandShapeOrPose as XRHandPose;
        }


        void OnDisable() => _HandTrackingEvents.jointsUpdated.RemoveListener(OnJointsUpdated);
    
        void OnJointsUpdated(XRHandJointsUpdatedEventArgs eventArgs){
            if (!isActiveAndEnabled || Time.timeSinceLevelLoad < _TimeOfLastConditionCheck + _GestureDetectionInterval)
                return;

            var detected =
                _HandTrackingEvents.handIsTracked &&
                _HandShape != null && _HandShape.CheckConditions(eventArgs) ||
                _HandPose != null && _HandPose.CheckConditions(eventArgs);

            if (!_WasDetected && detected){
                _PerformedTriggered = false;
                _HoldStartTime = Time.timeSinceLevelLoad;
            }else if (_WasDetected && !detected){
                _GestureEnded?.Invoke();
            }

            _WasDetected = detected;

            // hand gesture detected
            if (!_PerformedTriggered && detected){
                var holdTimer = Time.timeSinceLevelLoad - _HoldStartTime;
                if (holdTimer > _MinimumHoldTime){
                    _GesturePerformed?.Invoke();
                    _PerformedTriggered = true;
                    SceneManager.LoadScene("Scene1");
                }
            }

            _TimeOfLastConditionCheck = Time.timeSinceLevelLoad;
        }
    }
}

