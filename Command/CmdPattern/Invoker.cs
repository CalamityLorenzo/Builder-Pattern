namespace command
{
    using System;
    using System.Collections.Generic;
    public class ModifyProductInvoker
    {
        private readonly List<ICommand> _commands = new List<ICommand>();
        private ICommand _command;

        public void SetCommand(ICommand command)=>_command = command;

        public void Invoke(){
            _commands.Add(_command);
            _command.ExecuteAction();
        }
    }
}