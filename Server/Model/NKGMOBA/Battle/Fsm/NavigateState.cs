//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2020年10月20日 20:25:13
//------------------------------------------------------------

using ETModel.NKGMOBA.Battle.State;

namespace ETModel.NKGMOBA.Battle.Fsm
{
    public class NavigateState: AFsmStateBase
    {
        /// <summary>
        /// 互斥的状态，如果当前身上有这些状态，将无法切换至此状态
        /// </summary>
        public static StateTypes ConflictState =
                StateTypes.RePluse | StateTypes.Dizziness | StateTypes.Striketofly | StateTypes.Sneer | StateTypes.Fear;


        public NavigateState()
        {
            StateTypes = StateTypes.Run;
            this.StateName = "Anim_Run1";
            this.Priority = 1;
        }

        public override StateTypes GetConflictStateTypeses()
        {
            return ConflictState;
        }

        public override void OnEnter(StackFsmComponent stackFsmComponent)
        {
        }

        public override void OnExit(StackFsmComponent stackFsmComponent)
        {
            Game.EventSystem.Run(EventIdType.CancelMove, stackFsmComponent.Entity.Id);
        }

        public override void OnRemoved(StackFsmComponent stackFsmComponent)
        {
            Game.EventSystem.Run(EventIdType.CancelMove, stackFsmComponent.Entity.Id);
        }
    }
}