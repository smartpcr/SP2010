using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace Workflows.DocumentWorkflow
{
	public sealed partial class DocumentWorkflow
	{
		#region Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
			this.CanModifyActivities = true;
			System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
			System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
			System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
			System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
			this.onWorkflowItemChanged1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
			this.logToHistoryListActivity1 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
			this.completeTask1 = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
			this.whileActivity1 = new System.Workflow.Activities.WhileActivity();
			this.createTask1 = new Microsoft.SharePoint.WorkflowActions.CreateTask();
			this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
			// 
			// onWorkflowItemChanged1
			// 
			this.onWorkflowItemChanged1.AfterProperties = null;
			this.onWorkflowItemChanged1.BeforeProperties = null;
			correlationtoken1.Name = "workflowToken";
			correlationtoken1.OwnerActivityName = "DocumentWorkflow";
			this.onWorkflowItemChanged1.CorrelationToken = correlationtoken1;
			this.onWorkflowItemChanged1.Name = "onWorkflowItemChanged1";
			this.onWorkflowItemChanged1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowItemChanged1_Invoked);
			// 
			// logToHistoryListActivity1
			// 
			this.logToHistoryListActivity1.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
			this.logToHistoryListActivity1.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
			this.logToHistoryListActivity1.HistoryDescription = "";
			this.logToHistoryListActivity1.HistoryOutcome = "";
			this.logToHistoryListActivity1.Name = "logToHistoryListActivity1";
			this.logToHistoryListActivity1.OtherData = "";
			this.logToHistoryListActivity1.UserId = -1;
			// 
			// completeTask1
			// 
			this.completeTask1.CorrelationToken = correlationtoken1;
			this.completeTask1.Name = "completeTask1";
			this.completeTask1.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
			this.completeTask1.TaskOutcome = null;
			this.completeTask1.MethodInvoking += new System.EventHandler(this.completeTask1_MethodInvoking);
			// 
			// whileActivity1
			// 
			this.whileActivity1.Activities.Add(this.onWorkflowItemChanged1);
			codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.TaskMarkedDone);
			this.whileActivity1.Condition = codecondition1;
			this.whileActivity1.Name = "whileActivity1";
			// 
			// createTask1
			// 
			this.createTask1.CorrelationToken = correlationtoken1;
			this.createTask1.ListItemId = -1;
			this.createTask1.Name = "createTask1";
			this.createTask1.SpecialPermissions = null;
			this.createTask1.TaskId = new System.Guid("00000000-0000-0000-0000-000000000000");
			this.createTask1.TaskProperties = null;
			this.createTask1.MethodInvoking += new System.EventHandler(this.createTask1_MethodInvoking);
			activitybind2.Name = "DocumentWorkflow";
			activitybind2.Path = "workflowId";
			// 
			// onWorkflowActivated1
			// 
			this.onWorkflowActivated1.CorrelationToken = correlationtoken1;
			this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
			this.onWorkflowActivated1.Name = "onWorkflowActivated1";
			activitybind1.Name = "DocumentWorkflow";
			activitybind1.Path = "workflowProperties";
			this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
			this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
			// 
			// DocumentWorkflow
			// 
			this.Activities.Add(this.onWorkflowActivated1);
			this.Activities.Add(this.createTask1);
			this.Activities.Add(this.whileActivity1);
			this.Activities.Add(this.completeTask1);
			this.Activities.Add(this.logToHistoryListActivity1);
			this.Name = "DocumentWorkflow";
			this.CanModifyActivities = false;

		}

		#endregion

		private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged1;

		private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity1;

		private Microsoft.SharePoint.WorkflowActions.CompleteTask completeTask1;

		private Microsoft.SharePoint.WorkflowActions.CreateTask createTask1;

		private WhileActivity whileActivity1;

		private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;









	}
}
