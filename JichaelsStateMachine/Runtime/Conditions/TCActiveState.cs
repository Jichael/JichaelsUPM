using UnityEngine;

namespace Jichaels.StateMachine
{
    public class TCActiveState : TransitionCondition
    {
        public override bool Condition => CheckState();

        public override void Reset()
        {

        }

        [SerializeField] private GameObject toCheck;
        [SerializeField] private bool wantedState;

        private bool CheckState()
        {
            return toCheck.activeInHierarchy == wantedState;
        }

    }
}