using System.Collections;
using RPSLS.StateMachine.States.Base;

namespace RPSLS.StateMachine.States
{
    public class InitialState : StateBase
    {
        internal override IEnumerator Initialise()
        {
            yield break;
        }
    }
}