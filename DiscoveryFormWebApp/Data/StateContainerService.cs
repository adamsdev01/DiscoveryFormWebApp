namespace DiscoveryFormWebApp.Data
{
    public class StateContainerService
    {
        /// <summary>
        /// The State property with an initial value
        /// </summary>
        public string? NoteValue { get ; set; }


        /// <summary>
        /// The event that will be raised for state changed
        /// </summary>
        public event Action? OnStateChange;

        /// <summary>
        /// The method that will be accessed by the sender component
        /// to update the state
        /// </summary>
        public void SetNoteValue(string value)
        {
            NoteValue = value;
            NotifyStateChanged();
        }

        /// <summary>
        /// The state change event notification
        /// </summary>
        private void NotifyStateChanged() => OnStateChange?.Invoke();


    }
}
