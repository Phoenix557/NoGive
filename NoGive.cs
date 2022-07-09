namespace Oxide.Plugins
{
    [Info("NoGive", "Phoenix", "1.0.0")]
    [Description("Don't show give notices")]
    public class NoGive : CovalencePlugin
    {
        #region OnServerMessage
        object OnServerMessage(string message, string name)
        {
            if (message.Contains("gave") && name == "SERVER")
            {
                return true;
            }
            return null;
        }
        #endregion

    }
}