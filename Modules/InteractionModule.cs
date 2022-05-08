using Discord.Interactions;
using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Bot.Modules
{
    public class InteractionModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly ulong roleID = //insert role ID here;
        
        [SlashCommand("ping", "Receive a ping message!")]

        public async Task HandlePingCommand()
        {
            await RespondAsync("Ping!");
        }

        [SlashCommand("components", "Demonstrate buttons and  select menus.")]
        public async Task HandleComponentCommand()
        {
            var button = new ButtonBuilder()
            {
                Label = "Button!",
                CustomId = "button",
                Style = ButtonStyle.Primary
            };

            var menu = new SelectMenuBuilder()
            {
                CustomId = "menu",
                Placeholder = "Sample Menu",
            };
            menu.AddOption("First Option", "first");
            menu.AddOption("Second Option", "second");

            var component = new ComponentBuilder();
            component.WithButton(button);
            component.WithSelectMenu(menu);

            await RespondAsync("testing", components: component.Build());
        }

        [ComponentInteraction("button")]
        public async Task HandleButtonInput()
        {
            await RespondWithModalAsync<DemoModal>("demo_modal");
        }

        [ComponentInteraction("menu")]
        public async Task HandleMenuSelection(string[] inputs)
        {
            await RespondAsync(inputs[0]);
        }

        [ModalInteraction("demo_modal")]
        public async Task HandleModalInput(DemoModal modal)
        {
            string input = modal.Greeting;
                await RespondAsync(input);
        }

        [UserCommand("give-role")]
        public async Task HandleUserCommand(IUser user)
        {
            await (user as SocketGuildUser).AddRoleAsync(roleID);
            var roles = (user as SocketGuildUser).Roles;
            string rolesList = string.Empty;
            foreach (var role in roles)
            {
                rolesList += role.Name + "\n";
            }

            await RespondAsync($"User {user.Mention} has the following roles:\n" + rolesList);
        }

        [MessageCommand("msg-command")]
        public async Task HandleMessageCommand(IMessage message)
        {
            await RespondAsync($"Message author is: {message.Author.Username}");
        }

    }

    public class DemoModal : IModal
    {
        public string Title => "Demo Title";
        [InputLabel("Send a greeting!")]
        [ModalTextInput("Greeting_Input", TextInputStyle.Short, placeholder: "Be nice...", maxLength: 100)]
        public string Greeting { get; set; }

    }
}
