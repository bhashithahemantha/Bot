using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Threading.Tasks;

[LuisModel("52b27baf-349f-426b-8be6-a468d77a2ed7", "d2f50503b1c24bc0b8b31b926bdf3943")]
[Serializable]
public class LuisDialog : LuisDialog<object>
{
    /// <param name="context">Dialog context.</param>
    /// <param name="result">The result from LUIS.</param>
    [LuisIntent("None")]
    public async Task None(IDialogContext context, LuisResult result)
    {
        await context.PostAsync("I'm sorry. I didn't understand you.");
        context.Wait(MessageReceived);
    }

    [LuisIntent("name")]
    public async Task name(IDialogContext context, LuisResult result)
    {
        await context.PostAsync("My name is testing bot...!");
        context.Wait(MessageReceived);
    }
}
//namespace bot.Dialogs
//{

//}