using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Utility
{
    public class Timer : MonoBehaviour
    {
        [SerializeField]
        private bool loop = false;

        [SerializeField]
        private UnityEvent OnTimerFinished = null;

        [SerializeField]
        private float timeToWait = 0;

        private void OnDisable()
        {
            StopCoroutine(TimerLoop());
        }

        private void OnEnable()
        {
            StartCoroutine(TimerLoop());
        }

        private IEnumerator TimerLoop()
        {

            yield return new WaitForSeconds(timeToWait);
            OnTimerFinished?.Invoke();

            if (loop)
                StartCoroutine(TimerLoop());
        }
    }
}