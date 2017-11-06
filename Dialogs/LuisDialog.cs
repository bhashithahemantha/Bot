using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace bot.Dialogs
{
    [LuisModel("52b27baf-349f-426b-8be6-a468d77a2ed7", "d2f50503b1c24bc0b8b31b926bdf3943")]
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        /// <param name="context">Dialog context.</param>
        /// <param name="result">The result from LUIS.</param>
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string message = $"Hi...!";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("name")]
        public async Task name(IDialogContext context, LuisResult result)
        {
            string message = $"My name is test Bot...!";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }
    }
}