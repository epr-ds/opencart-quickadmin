using System;
using System.Windows.Input;

namespace WinForms.Commands
{
    class CommandHandler : ICommand
    {
        #region Fields

        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public event EventHandler CanExecuteChanged;

        #endregion // Fields

        #region Constructors

        /// <summary>
        /// Creates a new command that can always execute.
        /// </summary>
        /// <param name="fn">The execution logic.</param>
        public CommandHandler(Action<object> fn) : this(fn, null) { }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="fn">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public CommandHandler(Action<object> fn, Predicate<object> canExecute)
        {
            _execute = fn ?? throw new ArgumentNullException("Execute");
            _canExecute = canExecute;
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
        #endregion // Constructors

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute(parameter);
        }

        public void Execute(object parameter) => _execute(parameter);

        #endregion // ICommand Members
    }
}
