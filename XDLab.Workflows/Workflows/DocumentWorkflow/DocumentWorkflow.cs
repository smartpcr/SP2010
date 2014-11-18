using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;

namespace Workflows.DocumentWorkflow
{
	public sealed partial class DocumentWorkflow : SequentialWorkflowActivity
	{
		public DocumentWorkflow()
		{
			InitializeComponent();
		}

		public Guid workflowId = default(System.Guid);
		public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

		private void createTask1_MethodInvoking(object sender, EventArgs e)
		{

		}

		private void onWorkflowItemChanged1_Invoked(object sender, ExternalDataEventArgs e)
		{

		}

		private void completeTask1_MethodInvoking(object sender, EventArgs e)
		{

		}

		private void TaskMarkedDone(object sender, ConditionalEventArgs e)
		{

		}


	}
}
