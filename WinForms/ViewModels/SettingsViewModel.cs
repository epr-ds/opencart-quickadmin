using IniParser;
using IniParser.Model;
using REST;
using REST.Responses;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms.Services;
using WinForms.Commands;
using WinForms.Properties;

namespace WinForms.ViewModels
{
    public class SettingsViewModel : ViewModel
    {
        private readonly Settings settings;
        private string notification;

        public SettingsViewModel()
        {
            Notification = string.Empty;
            settings = Settings.Default;
            SaveCommand = new CommandHandler(o => Save());
            ImportCommand = new CommandHandler(o => Import(o as OpenFileDialog));
            ExportCommand = new CommandHandler(o => Export(o as SaveFileDialog));
            AddMinutesCommand = new CommandHandler(o => AddTimeCache());
            SubtractMinutesCommand = new CommandHandler(o => SubtractTimeCache());
            BackToCommand = new CommandHandler(o => BackTo(o as UserControl));
            LoginCommand = new CommandHandler(o => Login());
        }

        public ICommand SaveCommand { get; }
        public ICommand BackToCommand { get; }
        public ICommand AddMinutesCommand { get; }
        public ICommand SubtractMinutesCommand { get; }
        public ICommand ImportCommand { get; }
        public ICommand ExportCommand { get; }
        public ICommand LoginCommand { get; }

        public string Notification
        {
            get => notification;
            protected set
            {
                if (notification != value)
                {
                    notification = value;
                    NotifyPropertyChange(nameof(Notification));
                }
            }
        }

        public string TemplateFile
        {
            get => settings.template;
            set
            {
                if (settings.template != value)
                {
                    settings.template = value;
                    NotifyPropertyChange(nameof(TemplateFile));
                }
            }
        }

        public string Printer
        {
            get => settings.printer;
            set
            {
                if (settings.printer != value)
                {
                    settings.printer = value;
                    NotifyPropertyChange(nameof(Printer));
                }
            }
        }

        public bool SaveFiles
        {
            get => settings.saveFile;
            set
            {
                if (settings.saveFile != value)
                {
                    settings.saveFile = value;
                    NotifyPropertyChange(nameof(SaveFiles));
                }
            }
        }

        public bool UseCache
        {
            get => settings.useCache;
            set
            {
                if (settings.useCache != value)
                {
                    settings.useCache = value;
                    NotifyPropertyChange(nameof(UseCache));
                }
            }
        }

        public string DirectoryForFiles
        {
            get => settings.dirFiles;
            set
            {
                if (settings.dirFiles != value)
                {
                    settings.dirFiles = value;
                    NotifyPropertyChange(nameof(DirectoryForFiles));
                }
            }
        }

        public TimeSpan TimeCache
        {
            get => settings.cacheExpiration;
            set
            {
                if (settings.cacheExpiration != value)
                {
                    settings.cacheExpiration = value;
                    NotifyPropertyChange(nameof(TimeCache));
                }
            }
        }

        public string APIusername
        {
            get => settings.api_user;
            set
            {
                if (settings.api_user != value)
                {
                    settings.api_user = value;
                    NotifyPropertyChange(nameof(APIusername));
                }
            }
        }

        public string APIpassword
        {
            get => settings.api_pwd;
            set
            {
                if (settings.api_pwd != value)
                {
                    settings.api_pwd = value;
                    NotifyPropertyChange(nameof(APIpassword));
                }
            }
        }

        public string URLapi
        {
            get => settings.api_url;
            set
            {
                if (settings.api_url != value)
                {
                    settings.api_url = value;
                    NotifyPropertyChange(nameof(URLapi));
                }
            }
        }

        public ushort NumberOfItems
        {
            get => settings.api_items;
            set
            {
                if (settings.api_items != value)
                {
                    settings.api_items = value;
                    NotifyPropertyChange(nameof(NumberOfItems));
                }
            }
        }

        public string ServerSMTP
        {
            get => settings.host;
            set
            {
                if (settings.host != value)
                {
                    settings.host = value;
                    NotifyPropertyChange(nameof(ServerSMTP));
                }
            }
        }

        public ushort PortSMTP
        {
            get => settings.port;
            set
            {
                if (settings.port != value)
                {
                    settings.port = value;
                    NotifyPropertyChange(nameof(PortSMTP));
                }
            }
        }

        public string Subject
        {
            get => settings.subject;
            set
            {
                if (settings.subject != value)
                {
                    settings.subject = value;
                    NotifyPropertyChange(nameof(Subject));
                }
            }
        }

        public string MailContent
        {
            get => settings.message;
            set
            {
                if (settings.message != value)
                {
                    settings.message = value;
                    NotifyPropertyChange(nameof(MailContent));
                }
            }
        }

        public string Email
        {
            get => settings.email;
            set
            {
                if (settings.email != value)
                {
                    settings.email = value;
                    NotifyPropertyChange(nameof(Email));
                }
            }
        }

        public string EmailPassword
        {
            get => settings.email_pwd;
            set
            {
                if (settings.email_pwd != value)
                {
                    settings.email_pwd = value;
                    NotifyPropertyChange(nameof(EmailPassword));
                }
            }
        }

        private async void Login()
        {
            try
            {
                Save();
                ApiManager.Token = string.Empty;
                IQuickAdminApi api = ApiManager.API;
                LoginResponse response = await api.Login(APIusername, APIpassword);
                if (!string.IsNullOrWhiteSpace(response.Error))
                {
                    Notification = response.Error;
                }
                else
                {
                    Notification = response.Success;
                    ApiManager.Token = response.Token;
                }
            }
            catch (Exception)
            {
                Notification = "No se ha podido inicar sesión. Revise la configuración.";
            }
            finally
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                Notification = string.Empty;
            }
        }

        private async void Save()
        {
            settings.Save();
            Notification = "Configuración guardada";
            await Task.Run(() => Task.Delay(TimeSpan.FromSeconds(2)));
            Notification = string.Empty;
        }

        private async void Export(SaveFileDialog dialog)
        {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData data = new IniData();

                // General tab settings
                data["general"]["template"] = TemplateFile;
                data["general"]["save_files"] = SaveFiles.ToString();
                data["general"]["dir_toSave"] = DirectoryForFiles;
                data["general"]["use_cache"] = UseCache.ToString();
                data["general"]["time_cache"] = TimeCache.ToString();
                data["general"]["printer"] = Printer;

                // API Tab settings
                data["api"]["user"] = APIusername;
                data["api"]["url"] = URLapi;
                data["api"]["n_items"] = NumberOfItems.ToString();

                // Mail tab settings
                data["correo"]["host"] = ServerSMTP;
                data["correo"]["port"] = PortSMTP.ToString();
                data["correo"]["email"] = Email;
                data["correo"]["subject"] = Subject;
                data["correo"]["message"] = MailContent.Replace("\r\n", string.Empty);

                // Write file
                parser.WriteFile(dialog.FileName, data);

                Notification = "Configuración exportada";
                await Task.Run(() => Task.Delay(TimeSpan.FromSeconds(3)));
                Notification = string.Empty;
            }
        }

        private void Import(OpenFileDialog dialog)
        {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData data = parser.ReadFile(dialog.FileName);

                // General tab settings
                TemplateFile = data["general"]["template"];
                SaveFiles = bool.Parse(data["general"]["save_files"]);
                DirectoryForFiles = data["general"]["dir_toSave"];
                Printer = data["general"]["printer"];
                UseCache = bool.Parse(data["general"]["use_cache"]);
                TimeCache = TimeSpan.Parse(data["general"]["time_cache"]);

                // API Tab settings
                APIusername = data["api"]["user"];
                URLapi = data["api"]["url"];
                NumberOfItems = ushort.Parse(data["api"]["n_items"]);

                // Mail tab settings
                ServerSMTP = data["correo"]["host"];
                PortSMTP = ushort.Parse(data["correo"]["port"]);
                Email = data["correo"]["email"];
                Subject = data["correo"]["subject"];
                MailContent = data["correo"]["message"];

                Save();
            }
        }

        private void BackTo(UserControl control) => control.Dispose();

        private void AddTimeCache() => TimeCache = TimeCache.Add(TimeSpan.FromMinutes(10));

        private void SubtractTimeCache()
        {
            if (TimeCache.Minutes <= 0)
                TimeCache = TimeSpan.FromMinutes(0);
            else
                TimeCache = TimeCache.Subtract(TimeSpan.FromMinutes(10));
        }
    }
}
