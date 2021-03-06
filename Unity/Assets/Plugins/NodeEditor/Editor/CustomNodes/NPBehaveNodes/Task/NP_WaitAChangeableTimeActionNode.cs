//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2019年9月26日 19:47:29
//------------------------------------------------------------

using System.Collections.Generic;
using ETModel;
using NodeEditorFramework;
using Plugins.NodeEditor.Editor.Canvas;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;
using Node = NPBehave.Node;

namespace  Plugins.NodeEditor.Editor.NPBehaveNodes
{
    /// <summary>
    /// 等待一个可变化的时间，用于处理突如其来的CD变化
    /// </summary>
    [Node(false, "NPBehave行为树/Task/等待一个可变化的时间", typeof(NPBehaveCanvas))]
    public class NP_WaitAChangeableTimeActionNode: NP_TaskNodeBase
    {
        /// <summary>
        /// 内部ID
        /// </summary>
        private const string Id = "等待一个可变化的时间";

        /// <summary>
        /// 内部ID
        /// </summary>
        public override string GetID => Id;
        
        public NP_ActionNodeData NP_ActionNodeData =
                new NP_ActionNodeData() { NodeType = NodeType.Task, NpClassForStoreAction = new NP_WaitAChangeableTimeAction() };

        public override NP_NodeDataBase NP_GetNodeData()
        {
            return NP_ActionNodeData;
        }

        public override void NodeGUI()
        {
            NP_ActionNodeData.NodeDes = EditorGUILayout.TextField(NP_ActionNodeData.NodeDes);
        }
    }
}