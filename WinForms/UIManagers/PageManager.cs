using System.Windows.Forms;
using System.Collections.Generic;

namespace WinForms.UIManagers
{
    class PageManager
    {
        private Panel menuPanel;
        private Panel mainPanel;
        private Panel currentPanel;
        private UserControl currentPage;
        private Stack<UserControl> currentPageStack;
        private readonly Stack<UserControl> pagesMenu;
        private readonly Stack<UserControl> pagesMain;
        
        private static PageManager _instance;

        public static PageManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PageManager();

                return _instance;
            }
        }
        private PageManager()
        {
            pagesMain = new Stack<UserControl>();
            pagesMenu = new Stack<UserControl>();
        }

        public Panel SubPanel
        {
            set => menuPanel = value;
        }

        public Panel MainPanel
        {
            set => mainPanel = value;
        }


        public void SwitchToMainPanel()
        {
            menuPanel.SendToBack();
            currentPanel = mainPanel;
            currentPanel.BringToFront();
            currentPageStack = pagesMain;
        }

        public void SwitchToMenuPanel()
        {
            mainPanel.SendToBack();
            currentPanel = menuPanel;
            currentPanel.BringToFront();
            currentPanel.Show();
            currentPageStack = pagesMenu;
        }

        private void ShowCurrentPage()
        {
            currentPanel?.Controls.Add(currentPage);
            currentPage.Dock = DockStyle.Fill;
            currentPage.BringToFront();
            currentPage.Show();
        }

        public void NextPage(UserControl page)
        {
            if (currentPageStack.Count > 0)
            {
                currentPage.Hide();
                currentPanel?.Controls.Remove(currentPage);
            }

            currentPageStack.Push(currentPage);
            
            currentPage = page;

            ShowCurrentPage();
        }

        public void PrevPage()
        {
            currentPanel?.Controls.Remove(currentPage);
            currentPage.Hide();
            currentPage.Dispose();

            if (currentPageStack == pagesMain)
            {
                currentPage = currentPageStack.Pop();

                if (currentPageStack.Count == 0)
                    SwitchToMenuPanel();

                ShowCurrentPage();
            }
            else if (currentPageStack == pagesMenu)
            {
                if (currentPageStack.Count == 0) 
                    return;

                currentPage = currentPageStack.Pop();
                ShowCurrentPage();
            }
        }
    }
}