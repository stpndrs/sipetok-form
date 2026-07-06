namespace sipetok_form.Models
{
    internal class ItemMenu
    {
        public int Value { get; set; }

        public string Label { get; set; }

        public ItemMenu(int value, string label)
        {
            Value = value;
            Label = label;
        }
    }
}
