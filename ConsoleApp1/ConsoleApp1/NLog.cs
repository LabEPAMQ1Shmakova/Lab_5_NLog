using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;

namespace ConsoleApp1
{
    class NLog
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        public void StartProgram()
        {
            log.Info("Запуск программы");
        }

        public void ErrorParse()
        {
            log.Error("Неверный ввод данных!");
        }

        public void StopProgram()
        {
            log.Info("Завершение программы");
        }

        public void SuccessSolve(string name)
        {
            log.Debug("Плотность нефтепродукта {0} успешно рассчитана!", name);
        }
    }
}
 