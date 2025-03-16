using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWinform
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinMain());
            EncryptConfigSection("connectionStrings");
        }

        // 암호화
        static void EncryptConfigSection(string sectionName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection section = config.GetSection(sectionName);

            if (section != null && !section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save(ConfigurationSaveMode.Modified);
                Console.WriteLine($"{sectionName} 섹션이 암호화되었습니다.");
            }
            else
            {
                Console.WriteLine($"{sectionName} 섹션이 이미 암호화되었거나 존재하지 않습니다.");
            }
        }

        // appconfig connectionStrings 복호화
        static void DecryptConfigSection(string sectionName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection section = config.GetSection(sectionName);

            if (section != null && section.SectionInformation.IsProtected)
            {
                section.SectionInformation.UnprotectSection();
                config.Save(ConfigurationSaveMode.Modified);
                Console.WriteLine($"{sectionName} 섹션이 복호화되었습니다.");
            }
            else
            {
                Console.WriteLine($"{sectionName} 섹션이 이미 복호화되었거나 존재하지 않습니다.");
            }
        }
    }
}
