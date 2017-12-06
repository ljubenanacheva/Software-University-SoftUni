﻿namespace TeamBuilder.App.Commands
{
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;

    public class LogoutCommand : Command
    {
        private const string Success = "User {0} successfully logged out!";

        public LogoutCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();
            var username = this.Session.User.Username;
            this.Session.LogOut();

            return string.Format(Success, username);
        }
    }
}
