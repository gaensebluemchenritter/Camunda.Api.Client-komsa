
using System;

namespace Camunda.Api.Client.History
{
    public class HistoricUserOperation
    {
        /// <summary>
        /// The id of the user operation.
        /// </summary>
        public string Id;
        /// <summary>
        /// The deployment id of the operation.
        /// </summary>
        public string DeploymentId;
        /// <summary>
        /// The id of the process instance this operation is part of.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The key of the process instance this operation is part of.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id of the execution that the operation belongs to.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The id of the case execution the operation belongs to.
        /// </summary>
        public string CaseExecutionId;
        /// <summary>
        /// The id of the case definition the operation belongs to.
        /// </summary>
        public string CaseDefinitionId;
        /// <summary>
        /// The id of the instance of the case definition the operation belongs to.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        /// The id of the task that is associated to this user operation. 
        /// </summary>
        public string TaskId;
        /// <summary>
        /// The id of the Job that is associated to this user operation. 
        /// </summary>
        public string JobId;

        /// <summary>
        /// The id of the JobDefinition that is associated to this user operation. 
        /// </summary>
        public string JobDefinitionId;
        /// <summary>
        /// The id of the Batch that is associated to this user operation. 
        /// </summary>
        public string BatchId;
        /// <summary>
        /// The id of the User (login) that is associated to this user operation. 
        /// </summary>
        public string UserId;
        /// <summary>
        /// The time of this operation. 
        /// </summary>
        public DateTime? Timestamp;
        /// <summary>
        /// The Operation Id of the UserOperation.
        /// </summary>
        public string OperationId;
        /// <summary>
        /// The id of the ExternalTask that is associated to this user operation. 
        /// </summary>
        public string ExternalTaskId;
        /// <summary>
        /// The type of operation that is associated to this user operation. (e.g.:Claim, Assign)
        /// </summary>        
        public string OperationType;
        /// <summary>
        /// The type of entity that is associated to this user operation. (e.g.:Task)
        /// </summary>   
        public string EntityType;
        /// <summary>
        /// The property that is associated to this user operation. (e.g.:assignee, delete)
        /// </summary>  
        public string Property;
        /// <summary>
        /// The old value of this user operation. 
        /// </summary>  
        public string OrgValue;
        /// <summary>
        /// The new value of this user operation. 
        /// </summary>  
        public string NewValue;

        public DateTime? RemovalTime;

        public string RootProcessInstanceId;

        public string Category;

        public string Annotation;

    }
}
