namespace MenuWF.UIElements;

public class Animation
{
    public string Id { get; set; }
    public float Value { get; set; }
    public float StartValue { get; set; }
    private float targetValue { get; set; }
    public float TargetValue
    {
        get => targetValue;
        set
        {
            targetValue = value;
            Reverse = value < Value ? true : false;
        };
    }

    public float Volume;
    public bool Reverse = false;
    public enum AnimationStatus
    {
        Requested,
        Active,
        Complited
    }
    public AnimationStatus Status { get; set; }
    public float Step() => Math.Abs(Volume) / 11;

    public delegate void ControlMethod();
    private ControlMethod InvalidateControl;

    public Animation(string Id, ControlMethod InvalidateControl, float Value, float TargetValue)
    {
        this.Id = Id;
        this.InvalidateControl = InvalidateControl;
        this.Value = Value;
        this.TargetValue = TargetValue;
        StartValue = Value;
        Volume = TargetValue - Value;
    }

    public void UpdateFrame()
    {
        Status = AnimationStatus.Active;

        if (!Reverse)
        {
            if (Value <= targetValue)
            {
                Value += Step();
                if (Value >= targetValue)
                {
                    Value = targetValue;
                    Status = AnimationStatus.Complited;
                }
            }
        }

        if (Reverse)
        {
            if (Value >= targetValue)
            {
                Value -= Step();
                if (Value <= targetValue)
                {
                    Value = targetValue;
                    Status = AnimationStatus.Complited;
                }
            }
        }
        InvalidateControl.Invoke()
    }
}
