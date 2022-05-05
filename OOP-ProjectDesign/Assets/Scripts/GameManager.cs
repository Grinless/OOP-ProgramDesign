using System.Collections;
using UnityEngine;

namespace Game.Systems
{
    public class GameManager : EngineFunctionProvider
    {
        float _currentTime;
        float _timeTillBoss;
        bool _playerSpawned;
        static Entity _playerEntity;
        static Entity _bossEntity;

        public static Entity Entity_Player {
            get { return _playerEntity; }
        }

        public static Entity Entity_Boss {
            get { return _bossEntity; }
        }

        protected override void UpdateCall()
        {
            base.UpdateCall();
        }

        private void UpdateTime()
        {

        }

        private void EditUI()
        {

        }

        private void SetUpGame()
        {

        }

        private void CheckWinCondition()
        {

        }
    }

    public class Timer
    {
        private float _currentTime;
        private bool _complete;

        public bool TimerComplete {
            get => _complete;
        }

        public float Time {
            get => _currentTime;
        }

        public Timer(float maxTime)
        {
            _currentTime = maxTime;
        }

        public void SetNewTime(float value)
        {
            _currentTime = value;
        }

        public void StartTimer()
        {
            do
            {
                _currentTime -= Time.deltaTime;

            } while (_currentTime <= 0);

            _complete = true;
        }
    }
}