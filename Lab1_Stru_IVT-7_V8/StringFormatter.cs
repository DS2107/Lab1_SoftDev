/*
 В Production Code написать класс StringFormatter с методом string ShortFileString(string
path), который во входной строке с полным путем к файлу оставляет только короткое
имя файла, меняет расширение на TMP (в том числе, если исходный файл не имеет
расширения) и переводит все символы нижнего регистра в символы верхнего. Если
строка пустая, то метод возвращает также пустую строку; если строка является null, то
метод бросает исключение NullReferenceException. В Test Code написать тесты, которые
проверяют корректность работы метода.
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab1_Stru_IVT_7
{

    /// <summary>
    /// Класс для редактирования строки 
    /// </summary>
    public class StringFormatter
    {
        /// <summary>
        /// Метод который проверяет путь 
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns></returns>
        public string ShortFileString(string path)
        {
            /*
              Если
              строка пустая, то метод возвращает также пустую строку, если строка является null, то
              метод бросает исключение NullReferenceException.
           */
            if (path == "")
                return path;
            else if (path == null)
                throw new NullReferenceException("Укажите файл");

            return path;
        } // ShortFileString

        /// <summary>
        /// Из пути берем имя файла
        /// </summary>
        /// <param name="path">Полное имя файла или его путь</param>
        /// <returns></returns>
        public string SelectShortName(string path)
        {
            return Path.GetFileName(path);
        } // SelectShortName

        /// <summary>
        /// Меняет расширение файла
        /// </summary>
        /// <param name="file">файл с расширением</param>
        /// <returns></returns>
        public string SelectExpansion(string file)
        {
           return Path.ChangeExtension(file, ".tmp"); ;
        } // SelectExpansion

        /// <summary>
        /// Делает большие буквы 
        /// </summary>
        /// <param name="file">файл</param>
        /// <returns></returns>
        public string UpperString(string file)
        {

            return file.ToUpper();
        } // UpperString
    }
}
