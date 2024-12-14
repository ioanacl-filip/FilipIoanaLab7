namespace FilipIoanaLab7;
class ValidationBehaviour : Behavior<Editor>
{
    protected override void OnAttachedTo(Editor entry)
    {
        entry.TextChanged += OnEntryTextChanged;
        base.OnAttachedTo(entry);
    }
    protected override void OnDetachingFrom(Editor entry)
    {
        entry.TextChanged -= OnEntryTextChanged;
        base.OnDetachingFrom(entry);
    }
    void OnEntryTextChanged(object? sender, TextChangedEventArgs args)
    {
        if (sender is Editor editor)
        {
            editor.BackgroundColor =
                string.IsNullOrEmpty(args.NewTextValue)
                ? Color.FromRgba("#AA4A44")
                : Color.FromRgba("#FFFFFF");
        }
    }
}