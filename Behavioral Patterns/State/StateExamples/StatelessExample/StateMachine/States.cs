namespace StatelessExample.StateMachine
{
    public enum ActivityState 
    {
        Created,
        Todo,
        WorkInProgress,
        CodeReview,
        Revision,
        DeployStaging,
        BusinessValidation,
        DeployProduction,
        Done
    }
}
