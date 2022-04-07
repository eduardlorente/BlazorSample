namespace BlazorApp
{
    public class ApplicationState
    {


        public IntHolder CounterState { get; set; }


        public ApplicationState()
        {
            CounterState = new IntHolder();
        }
    }
}
