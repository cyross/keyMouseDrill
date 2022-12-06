namespace KeyMouDrill
{
    public enum KeyAction
    {
        Tap,  // キー・ボタンを1回押した
        Push,  // キー・ボタンを押した
        Release // キー・ボタンを離した
    }

    public enum KeyType
    {
        AlphaNum,
        Symbol,
        NumPad,
        Function,
        Meta,
        System
    }
}
