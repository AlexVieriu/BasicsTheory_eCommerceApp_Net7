namespace BlazorApp.Server.Pages.Theory._34_StateManagement.Stores;

public class CounterStore
{
    // we store the State of the component
    private CounterState _state;

    // the store constructor initalize the default Sate with 0 when the CounterStore is injected into the razor page
    public CounterStore()
    {
        _state = new CounterState(0);
    }

    public void IncrementCount()
    {
        // create a var and take the value of the current state
        var count = this._state.Count;
        count++;
        _state = new CounterState(count);
    }

    public void DecrementCount()
    {
        var count = _state.Count;
        count--;
        _state = new CounterState(count);
    }

    public CounterState GetState()
    {
        return _state;
    }

    #region
    // encapsulate a method taht has no parameters and does not return a value
    private Action _Listeners;

    //register the listeners
    public void AddStateChangeListeners(Action listener)
        => _Listeners += listener;

    public void RemoveStateChangeListeners(Action listener)
        => _Listeners -= listener;

    public void BroadcastStateChange()
        => _Listeners.Invoke();

    #endregion
}

// another class
public class CounterState
{
    public int Count { get; }

    public CounterState(int count)
    {
        Count = count;
    }
}
